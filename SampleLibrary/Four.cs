namespace SampleLibrary;

public class Four
{
    public async Task<int> FuncFour()
    {
        System.Diagnostics.Debug.WriteLine("FuncFour started");

        await Task.Delay(4000);

        System.Diagnostics.Debug.WriteLine("FuncFour ended");

        return await Task.FromResult(4);
    }
}
