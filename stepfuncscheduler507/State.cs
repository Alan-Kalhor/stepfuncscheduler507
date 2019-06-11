using System;
using System.Collections.Generic;
using System.Text;

namespace stepfuncscheduler507
{
    /// <summary>
    /// The state passed between the step function executions.
    /// </summary>
    public class State
    {
        /// <summary>
        /// Input value when starting the execution
        /// </summary>
        public string Input1 { get; set; }
        public string Input2 { get; set; }
        public string Result { get; set; }
        /// <summary>
        /// The message built through the step function execution.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The number of seconds to wait between calling the ShowResult task and Calc task.
        /// </summary>
        public int WaitInSeconds { get; set; }

        public bool IsValid { get; set; }
    }
}
