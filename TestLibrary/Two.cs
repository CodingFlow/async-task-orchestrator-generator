namespace TestLibrary;

public class Two
{
    public async Task<int> FuncTwo()
    {
        System.Diagnostics.Debug.WriteLine("FuncTwo started");

        await Task.Delay(1200);

        System.Diagnostics.Debug.WriteLine("FuncTwo ended");

        return await Task.FromResult(2);
    }
}
