using System;

namespace AsyncTaskOrchestratorGenerator
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AsyncTaskOrchestratorAttribute : Attribute
    {
        public AsyncTaskOrchestratorAttribute(string containingTypeName = "Orchestrator", string methodName = "Execute") {
        }
    }
}