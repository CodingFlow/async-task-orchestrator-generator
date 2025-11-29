namespace SampleLibrary;

public class Final
{
    public async Task<int> FuncFinal(int inputOne, int inputTwo)
    {
        System.Diagnostics.Debug.WriteLine("FuncFinal started");
        return await Task.FromResult(inputOne + inputTwo);
    }
}
