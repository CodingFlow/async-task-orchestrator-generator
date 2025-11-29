using AsyncTaskOrchestratorGenerator;

namespace TestLibrary;

[AsyncTaskOrchestrator]
internal class OrchestratorSpec
{
    private readonly A a;
    private readonly B b;
    private readonly C c;
    private readonly D d;
    private readonly E e;
    private readonly F f;

    public OrchestratorSpec(A a, B b, C c, D d, E e, F f)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.e = e;
        this.f = f;
    }

    public Task<int> Spec()
    {
        var resultA = a.CallA(); 
        var resultB = b.CallB();
        var resultC = c.CallC(resultA.Result, resultB.Result);
        var resultD = d.CallD(); 
        var resultE = e.CallE(resultD.Result);
        return f.CallF(resultC.Result, resultE.Result);
    }
}
