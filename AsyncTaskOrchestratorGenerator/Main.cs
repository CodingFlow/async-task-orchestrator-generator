using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using System.Threading;

namespace AsyncTaskOrchestratorGenerator
{
    [Generator]
    public class Main : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context) {
            var types = context.SyntaxProvider.ForAttributeWithMetadataName(
                $"AsyncTaskOrchestratorGenerator.{nameof(AsyncTaskOrchestratorAttribute)}",
                predicate: IsSyntaxTargetForGeneration,
                transform: GetSemanticTargetForGeneration
            );

            context.RegisterSourceOutput(types, Execute);
        }

        private static bool IsSyntaxTargetForGeneration(SyntaxNode syntaxNode, CancellationToken token) {
            return syntaxNode is TypeDeclarationSyntax;
        }

        private static (INamedTypeSymbol, SemanticModel) GetSemanticTargetForGeneration(GeneratorAttributeSyntaxContext context, CancellationToken cancellationToken) {
            
            return (context.TargetSymbol as INamedTypeSymbol, context.SemanticModel);
        }

        private static void Execute(SourceProductionContext context, (INamedTypeSymbol typeSymbol, SemanticModel semanticModel) typeInfo) {
            var (classSource, className) = OutputGenerator.GenerateClassOutputs(typeInfo);
            var (interfaceSource, interfaceName) = OutputGenerator.GenerateInterfaceOutputs(typeInfo.typeSymbol);

            context.AddSource($"{className}.generated.cs", SourceText.From(classSource, Encoding.UTF8, SourceHashAlgorithm.Sha256));
            context.AddSource($"{interfaceName}.generated.cs", SourceText.From(interfaceSource, Encoding.UTF8, SourceHashAlgorithm.Sha256));
        }
    }
}