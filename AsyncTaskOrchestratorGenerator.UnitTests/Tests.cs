using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Text;
using System.Reflection;
using System.Text;
using TestLibrary;
using VerifyCS = AsyncTaskOrchestratorGenerator.UnitTests.CSharpSourceGeneratorVerifier<AsyncTaskOrchestratorGenerator.Main>;

namespace AsyncTaskOrchestratorGenerator.UnitTests;

public class Tests
{
    private Assembly implementationAssembly;

    [SetUp]
    public void Setup() {
        implementationAssembly = GetAssembly("AsyncTaskOrchestratorGenerator");
    }

    [Test]
    public async Task OneInterface() {
        var source = await ReadCSharpFile<OrchestratorSpec>(true);
        var generatedClass = await ReadCSharpFile<Orchestrator>(false);
        var generatedInterface = await ReadCSharpFile<IOrchestrator>(false);

        await new VerifyCS.Test
        {
            CompilerDiagnostics = CompilerDiagnostics.None,
            TestState = {
                ReferenceAssemblies = ReferenceAssemblies.Net.Net90,
                AdditionalReferences =
                {
                    implementationAssembly,
                    GetAssembly("TestLibrary")
                },
                
                Sources = { source },
                GeneratedSources =
                {
                    (typeof(Main), "Orchestrator.generated.cs", SourceText.From(generatedClass, Encoding.UTF8, SourceHashAlgorithm.Sha256)),
                    (typeof(Main), "IOrchestrator.generated.cs", SourceText.From(generatedInterface, Encoding.UTF8, SourceHashAlgorithm.Sha256)),
                },
            },
        }.RunAsync();
    }

    private static Assembly GetAssembly(string name) {
        var implementationAssemblyName = Assembly.GetExecutingAssembly().GetReferencedAssemblies().First(a => a.FullName.Contains(name));
        return Assembly.Load(implementationAssemblyName);
    }

    private static async Task<string> ReadCSharpFile<T>(bool isTestLibrary) {
        var currentDirectory = GetCurrentDirectory();

        var targetDirectory = isTestLibrary ? GetTestLibraryDirectory(currentDirectory) : currentDirectory;

        var searchPattern = $"{typeof(T).Name}*.cs";
        var file = targetDirectory.GetFiles(searchPattern).First();

        using var fileReader = new StreamReader(file.OpenRead());
        return await fileReader.ReadToEndAsync();
    }

    private static DirectoryInfo? GetCurrentDirectory() {
        return Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName);
    }

    private static DirectoryInfo GetTestLibraryDirectory(DirectoryInfo currentDirectory) {
        return currentDirectory.Parent.GetDirectories("TestLibrary").First();
    }
}