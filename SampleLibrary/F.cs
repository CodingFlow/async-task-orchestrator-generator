namespace SampleLibrary;

public class F
{
    public async Task<int> CallF(int inputOne, int inputTwo)
    {
        System.Diagnostics.Debug.WriteLine("FuncFinal started");
        return await Task.FromResult(inputOne + inputTwo);
    }
}
