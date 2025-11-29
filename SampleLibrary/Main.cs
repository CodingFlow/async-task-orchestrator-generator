namespace SampleLibrary;

public class Main
{
    public async Task<int> ExecuteAsync() {
        var orchestrator = new Orchestrator(new A(), new B(), new C(), new D(), new E(), new F());

        var result = await orchestrator.Execute();

        return result;
    }
}
