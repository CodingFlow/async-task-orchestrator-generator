namespace SampleLibrary;

public class F
{
    public async Task<int> CallF(int inputOne, int inputTwo)
    {
        await Utils.DebugDelay(nameof(CallF), 0);
        return await Task.FromResult(inputOne + inputTwo);
    }
}
