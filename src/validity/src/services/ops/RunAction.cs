//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    partial class TestApp<A>
    {
        Duration ExecExplicit(IExplicitTest unit, string hostpath, IList<TestCaseRecord> results)
        {
            var clock = Time.counter(false);
            var messages = sys.empty<IAppMsg>();
            var casename = TestCaseName(unit);

            try
            {
                clock.Start();
                unit.Execute();
                clock.Stop();

                messages = CollectMessages(unit, casename,clock);
                results.WithItems(CollectResults(unit, casename, clock));

            }
            catch(Exception e)
            {
                clock.Stop();
                messages = CollectMessages(unit, casename, clock, e);
                results.WithItems(CollectResults(unit,casename, clock,e));
            }
            finally
            {
                term.print(messages);
            }
            return clock;
        }
    }
}