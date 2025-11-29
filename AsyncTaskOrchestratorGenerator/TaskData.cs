using System.Collections.Generic;

namespace AsyncTaskOrchestratorGenerator
{
    internal struct TaskData
    {
        public string OutputName { get; set; }
        public string MethodCallName { get; set; }
        public string MethodCallReturnType { get; set; }
        public IEnumerable<string> DependenciesOutputNames { get; set; }
        public string TaskName { get; set; }
    }
}
