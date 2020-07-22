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
        Duration RunCase(IUnitTest unit, MethodInfo method, IList<TestCaseRecord> cases)
        {
            var exectime = Duration.Zero;
            var casename = OpUriBuilder.TestCase(method);

            var clock = counter(false);

            var collected = new List<IAppMsg>();
            try
            {
                if(DiagnosticMode)
                    term.print($"Executing case {unit.HostType.Name}/{method.Name}");            

                var tsStart = Time.now();
                collected.Add(PreCase(casename, tsStart));

                clock.Start();
                method.Invoke(unit,null);                    
                clock.Stop();

                collected.AddRange(unit.Dequeue());
                collected.Add(PostCase(casename, clock.Time, tsStart, Time.now()));
                
                var outcomes = unit.TakeOutcomes().ToArray();
                if(outcomes.Length != 0)
                {
                    cases.WithItems(outcomes);
                    CaseLog.Deposit(outcomes);
                }
                else
                {
                    var success = TestCaseRecord.Define(casename, true, clock.Time);
                    cases.Add(success);
                    CaseLog.Deposit(success);
                }

                if(DiagnosticMode)
                    term.print($"Executed case {unit.HostType.Name}/{method.Name}");            

            }
            catch(Exception e)
            {                
                clock.Stop();
                collected.AddRange(unit.Dequeue());                
                collected.AddRange(FormatErrors(e, method));
                cases.Add(TestCaseRecord.Define(casename, false, clock.Time));                              
            }
            finally
            {                     
                Log.Deposit(collected);                
                Root.iter(collected.Where(m => !m.Displayed), term.print);
            }

            return exectime;
        }            
    }
}