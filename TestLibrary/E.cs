namespace TestLibrary;

public class E
{
    public async Task<int> CallE(int input)
    {
        System.Diagnostics.Debug.WriteLine("FuncFour started");

        await Task.Delay(4000);

        System.Diagnostics.Debug.WriteLine("FuncFour ended");

        return await Task.FromResult(5 + input);
    }
}
