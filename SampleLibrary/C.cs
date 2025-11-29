namespace SampleLibrary;

public class C
{
    public async Task<int> CallC(int inputOne, int inputTwo)
    {
        System.Diagnostics.Debug.WriteLine("FuncThree started");

        await Task.Delay(1000);

        System.Diagnostics.Debug.WriteLine("FuncThree ended");

        return await Task.FromResult(inputOne + inputTwo);
    }
}

