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
        Duration RunCase(IUnitTest unit, MethodInfo method, IList<TestCaseRecord> cases)
        {
            var exectime = Duration.Zero;
            var casename = OpUriBuilder.TestCase(method);
            var clock = counter(false);
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
                    outcomes.Add(TestCaseRecord.Define(casename, true, clock.Time));

                if(DiagnosticMode)
                    term.print($"Executed case {unit.HostType.Name}/{method.Name}");            

            }
            catch(Exception e)
            {                
                clock.Stop();
                messages.AddRange(unit.Dequeue());                
                messages.AddRange(FormatErrors(e, method));
                outcomes.Add(TestCaseRecord.Define(casename, false, clock.Time));                              
            }
            finally
            {                     
                Log.Deposit(messages);   
                cases.WithItems(outcomes);
                CaseLog.Deposit(outcomes.Array());
                //Root.iter(messages.Where(m => !m.Displayed), term.print);
            }

            return exectime;
        }            
    }
}