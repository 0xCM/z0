//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    partial class TestApp<A>
    {
        public void RunUnit(Type host, IUnitTest unit)
        {
            if(DiagnosticMode)
                term.print($"Executing {host.DisplayName()} cases");

            var results = new List<TestCaseRecord>();
            try
            {
                var execTime = Duration.Zero;
                var clock = Time.counter(true);
                var tsStart = Time.now();

                if(unit is IExplicitTest et)
                    ExecExplicit(et, host.Name, results);
                else
                {
                    root.iter(FindTests(host), t =>  execTime += RunCase(unit, t, results));
                    BenchmarkQueue.Enqueue(unit.TakeBenchmarks().Array());
                }

                clock.Stop();

                var hosturi = ApiUri.HostUri(host);
                term.print(PostUnit(hosturi, clock.Time, tsStart, Time.now()));

            }
            catch(Exception e)
            {
                Wf.Error(e, $"Harness execution failed while running {unit.GetType().Name}");
            }
            finally
            {
                TestResultQueue.Enqueue(results);
            }
        }

        public void RunUnit(Type host, string[] filters)
        {
            if(!HasTests(host, filters))
                return;

            Demands.insist(Wf != null);
            using var unit = host.Instantiate<IUnitTest>();
            if(unit.Enabled)
            {
                unit.SetMode(DiagnosticMode);
                unit.InjectShell(Wf);
                RunUnit(host, unit);
            }
        }
    }
}