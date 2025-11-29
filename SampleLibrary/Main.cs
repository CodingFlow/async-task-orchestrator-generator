namespace SampleLibrary;

public class Main
{
    public async Task<int> ExecuteAsync() {
        var orchestrator = new Orchestrator(new One(), new Two(), new Three(), new Four(), new Final());

        var result = await orchestrator.Execute();

        return result;
    }
}
