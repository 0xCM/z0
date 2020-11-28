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
    using static z;

    partial class TestApp<A>
    {
        public Duration RunCase(IUnitTest unit, MethodInfo method, IList<TestCaseRecord> cases)
        {
            var exectime = Duration.Zero;
            var casename = ApiUri.TestCase(method);
            var clock = Time.counter(false);
            var messages = new List<IAppMsg>();
            var outcomes = z.list<TestCaseRecord>();

            try
            {
                if(DiagnosticMode)
                    term.print($"Executing case {unit.HostType.Name}/{method.Name}");

                var tsStart = now();
                messages.Add(PreCase(casename, tsStart));

                clock.Start();
                method.Invoke(unit,null);
                clock.Stop();

                messages.AddRange(unit.Dequeue());
                messages.Add(PostCase(casename, clock.Time, tsStart, now()));

                outcomes.AddRange(unit.TakeOutcomes().Array());

                if(outcomes.Count == 0)
                    outcomes.Add(TestCaseRecord.define(casename, true, clock.Time));

                if(DiagnosticMode)
                    term.print($"Executed case {unit.HostType.Name}/{method.Name}");

            }
            catch(Exception e)
            {
                clock.Stop();
                messages.AddRange(unit.Dequeue());
                messages.AddRange(FormatErrors(e, method));
                outcomes.Add(TestCaseRecord.define(casename, false, clock.Time));
            }
            finally
            {
                term.print(messages);
                cases.WithItems(outcomes);
            }

            return exectime;
        }
    }
}