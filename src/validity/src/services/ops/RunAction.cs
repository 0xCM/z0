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
        public Duration RunAction(IUnitTest unit, Action exec)
        {
            var messages = new List<IAppMsg>();
            var clock = counter(false);
            var casename = TestActionName;
            var control = unit as ITestQueue;
            
            try
            {                                
                var tsStart = Time.now();
                messages.Add(PreCase(casename, tsStart));                
                
                clock.Start();
                exec();
                clock.Stop();

                messages.AddRange(unit.Dequeue());
                messages.Add(PostCase(casename, clock.Time, tsStart, Time.now()));

                var outcomes = control.TakeOutcomes().ToArray();                
                if(outcomes.Length != 0)
                    PostTestResults(outcomes);
                else
                    PostTestResult(TestCaseRecord.Define(casename,true,clock.Time));                              

            }
            catch(Exception e)
            {
                clock.Stop();
                messages.AddRange(unit.Dequeue());                
                messages.AddRange(FormatErrors(casename,e));
                PostTestResult(TestCaseRecord.Define(casename,false,clock.Time));                
            }
            finally
            {            
                term.print(messages);
            }
            return clock.Time;
        }    

        Duration ExecExplicit(IExplicitTest unit, string hostpath, IList<TestCaseRecord> results)
        {
            var clock = counter(false);
            var messages = Arrays.empty<IAppMsg>();
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
                Log.Deposit(messages);                
                Root.iter(messages.Where(m => !m.Displayed), term.print);
            }

            return clock;
        }

    }
}