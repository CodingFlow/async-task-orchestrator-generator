namespace SampleLibrary;

public class One
{
    public async Task<int> FuncOne()
    {
        System.Diagnostics.Debug.WriteLine("FuncOne started");

        await Task.Delay(1000);

        System.Diagnostics.Debug.WriteLine("FuncOne ended");

        return await Task.FromResult(1);
    }

    public int Blah() {
        return 5;
    }
}
