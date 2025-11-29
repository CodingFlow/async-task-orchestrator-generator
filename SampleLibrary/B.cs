namespace SampleLibrary;

public class B
{
    public async Task<int> CallB()
    {
        await Utils.DebugDelay(nameof(CallB), 1200);

        return await Task.FromResult(2);
    }
}
