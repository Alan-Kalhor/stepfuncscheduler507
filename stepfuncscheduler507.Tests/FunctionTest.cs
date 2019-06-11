using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using stepfuncscheduler507;

namespace stepfuncscheduler507.Tests
{
    public class FunctionTest
    {
        public FunctionTest()
        {
        }

        [Fact]
        public void TestCalc()
        {
            TestLambdaContext context = new TestLambdaContext();

            StepFunctionTasks functions = new StepFunctionTasks();

            var state = new State
            {
                Input1 = "4",
                Input2 = "3"
            };


            state = functions.Calculation(state, context);

            Assert.Equal(3, state.WaitInSeconds);
            Assert.Equal("7", state.Result);
        }
    }
}
