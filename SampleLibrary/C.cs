namespace SampleLibrary;

public class C
{
    public async Task<int> CallC(int inputOne, int inputTwo)
    {
        await Utils.DebugDelay(nameof(CallC), 1000);

        return await Task.FromResult(inputOne + inputTwo);
    }
}

