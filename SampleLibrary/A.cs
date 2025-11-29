namespace SampleLibrary;

public class A
{
    public async Task<int> CallA()
    {
        await Utils.DebugDelay(nameof(CallA), 1000);

        return await Task.FromResult(1);
    }
}
