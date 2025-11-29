namespace SampleLibrary;

internal class Utils
{
    public static async Task DebugDelay(string functionName, int delayTime) 
    {
        System.Diagnostics.Debug.WriteLine($"{functionName} started");

        await Task.Delay(delayTime);

        System.Diagnostics.Debug.WriteLine($"{functionName} ended");
    }
}
