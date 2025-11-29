namespace TestLibrary;

public class D
{
    public async Task<int> CallD()
    {
        System.Diagnostics.Debug.WriteLine("FuncFour started");

        await Task.Delay(4000);

        System.Diagnostics.Debug.WriteLine("FuncFour ended");

        return await Task.FromResult(4);
    }
}
