namespace SampleLibrary;

public class E
{
    public async Task<int> CallE(int input)
    {
        await Utils.DebugDelay(nameof(CallE), 1000);

        return await Task.FromResult(5 + input);
    }
}
