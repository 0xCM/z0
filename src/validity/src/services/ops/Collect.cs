//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Konst;

    partial class TestApp<A>
    {
        static IAppMsg[] CollectMessages(IUnitTest unit, string testName, Duration runtime, Exception e = null)
        {
            var messages = new List<IAppMsg>();
            var control = unit as ITestQueue;
            messages.AddRange(unit.Dequeue());
            if(e != null)
                messages.AddRange(FormatErrors(testName,e));
            else
                messages.Add(AppMsg.info($"{testName} executed. {runtime}"));
            return messages.ToArray();
        }

        static TestCaseRecord[] CollectResults(IExplicitTest unit, string casename, Duration runtime, Exception e = null)
        {
            var control = unit as ITestQueue;
            var outcomes = new List<TestCaseRecord>();
            if(e!= null)
                outcomes.Add(TestCaseRecord.Define(casename,false,runtime));
            else
            {
                outcomes.AddRange(control.TakeOutcomes());
                if(outcomes.Count == 0)
                    outcomes.Add(TestCaseRecord.Define(casename,true,runtime));
            }
            return outcomes.ToArray();
        }
    }
}