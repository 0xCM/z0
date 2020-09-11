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
        void RunUnit(Type host, IUnitTest unit)
        {
            if(DiagnosticMode)
                term.print($"Executing {host.DisplayName()} cases");

            var results = new List<TestCaseRecord>();
            try
            {
                var execTime = Duration.Zero;
                var clock = counter(true);
                var tsStart = Time.now();

                if(unit is IExplicitTest et)
                    ExecExplicit(et, host.Name,results);
                else
                {
                    z.iter(FindTests(host), t =>  execTime += RunCase(unit, t, results));
                    PostBenchResult(unit.TakeBenchmarks().Array());
                }

                clock.Stop();

                var hosturi = ApiUriBuilder.HostUri(host);
                term.print(PostUnit(hosturi, clock.Time, tsStart, Time.now()));

            }
            catch(Exception e)
            {
                term.error($"Harness execution failed: {e}");
            }
            finally
            {
                PostTestResults(results);
            }
        }

        public void RunUnit(Type host, string[] filters)
        {
            if(!HasTests(host, filters))
                return;

            using var unit = host.Instantiate<IUnitTest>();
            if(unit.Enabled)
            {
                unit.SetMode(DiagnosticMode);
                RunUnit(host, unit);
            }
        }
    }
}