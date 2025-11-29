namespace SampleLibrary;

public class D
{
    public async Task<int> CallD()
    {
        await Utils.DebugDelay(nameof(CallD), 4000);

        return await Task.FromResult(4);
    }
}
