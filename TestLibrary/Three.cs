namespace TestLibrary;

public class Three
{
    public async Task<int> FuncThree(int inputOne, int inputTwo)
    {
        System.Diagnostics.Debug.WriteLine("FuncThree started");

        await Task.Delay(1000);

        System.Diagnostics.Debug.WriteLine("FuncThree ended");

        return await Task.FromResult(inputOne + inputTwo);
    }
}

