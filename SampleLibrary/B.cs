namespace SampleLibrary;

public class B
{
    public async Task<int> CallB()
    {
        System.Diagnostics.Debug.WriteLine("FuncTwo started");

        await Task.Delay(1200);

        System.Diagnostics.Debug.WriteLine("FuncTwo ended");

        return await Task.FromResult(2);
    }
}
