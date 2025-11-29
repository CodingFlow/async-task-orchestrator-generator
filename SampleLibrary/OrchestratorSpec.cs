using AsyncTaskOrchestratorGenerator;

namespace SampleLibrary;

[AsyncTaskOrchestrator]
public class OrchestratorSpec
{
    private readonly One one;
    private readonly Two two;
    private readonly Three three;
    private readonly Four four;
    private readonly Final final;

    public OrchestratorSpec(One one, Two two, Three three, Four four, Final final)
    {
        this.one = one;
        this.two = two;
        this.three = three;
        this.four = four;
        this.final = final;
    }

    public Task<int> Spec()
    {
        var resultOne = one.FuncOne(); 
        var resultTwo = two.FuncTwo();
        var resultThree = three.FuncThree(resultOne.Result, resultTwo.Result);
        var resultFour = four.FuncFour(); 
        return final.FuncFinal(resultThree.Result, resultFour.Result);
    }
}
