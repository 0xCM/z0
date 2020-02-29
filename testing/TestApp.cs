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
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    /// <summary>
    /// Base type for test applications
    /// </summary>
    /// <typeparam name="A">The concrete subtype</typeparam>
    public abstract class TestApp<A> : TestContext<A>
        where A : TestApp<A>, new()
    {
        ConcurrentQueue<TestCaseRecord> TestResultQueue {get;}
            = new ConcurrentQueue<TestCaseRecord>();

        protected void Enqueue(IEnumerable<TestCaseRecord> outcomes)
            => TestResultQueue.Enqueue(outcomes);

        protected void Enqueue(TestCaseRecord outcome)
            => TestResultQueue.Enqueue(outcome);

        ConcurrentQueue<BenchmarkRecord> BenchmarkQueue {get;}
            = new ConcurrentQueue<BenchmarkRecord>();

        protected void Enqueue(IEnumerable<BenchmarkRecord> outcomes)
            => BenchmarkQueue.Enqueue(outcomes);

        protected BenchmarkRecord[] TakeSortedBenchmarks()
        {
            var records = BenchmarkQueue.ToArray();
            BenchmarkQueue.Clear();
            Array.Sort(records);
            return records;
        }

        protected TestCaseRecord[] TakeSortedResults()
        {
            static TestCaseRecord[] Sort(IEnumerable<TestCaseRecord> src)
                => src.OrderBy(x => x.Case).Where(x => !x.Succeeded).Concat(src.Where(x => x.Succeeded)).ToArray();

            var results = Sort(TestResultQueue);
            TestResultQueue.Clear();
            return results;
        }

        IEnumerable<Type> CandidateTypes()
            =>  from t in typeof(A).Assembly.Types().Realize<IUnitTest>()
                where t.Concrete() && t.Untagged<IgnoreAttribute>()
                select t;
        
        IEnumerable<Type> Hosts()
            => CandidateTypes().OrderBy(t => t.DisplayName());

        bool HasAny(Type host, string[] filters)        
        {
            if(filters.Length != 0)
            {
                var hostpath = host.DisplayName();
                if(!(filters.Length == 1 && String.IsNullOrEmpty(filters[0])))                        
                    if(!hostpath.ContainsAny(filters))
                        return false;
            }
            return true;
        }

        /// <summary>
        /// Executes the tests defined by a host type
        /// </summary>
        /// <param name="host">The host type</param>
        /// <param name="filters">Filters the host's test if nonempty</param>
        public void Run(Type host, string[] filters)
        {        
            if(!HasAny(host,filters))
                return;

            var hosturi = Identity.testhosturi(host);
            var results = new List<TestCaseRecord>();
            var unit = default(IUnitTest);
            try
            {
                var execTime = Duration.Zero;
                var runtimer = stopwatch();
                var clock = counter(false);
                
                unit = host.CreateInstance<IUnitTest>();
                if(!unit.Enabled)
                    return;

                unit.Configure(Config); 
                                
                clock.Start();
                
                var tsStart = now();

                if(unit is IExplicitTest et)  
                    ExecExplicit(et, host.Name,results);
                else
                {
                    iter(Tests(host), t =>  execTime += ExecCase(unit, t, results));                                    
                    Enqueue(unit.TakeBenchmarks().ToArray());
                }                
                clock.Stop();

                print(AftUnitMsg(hosturi, clock.Time, tsStart, now()));                
            }
            catch(Exception e)
            {
                error($"Harness execution failed: {e}");
            }  
            finally
            {
                Enqueue(results);
                if(unit is IDisposable d)
                    d.Dispose();
            }
        }

        const int TestNamePad = 50;
        
        const int TimeStampPad = 30;

        const int ElapsedPad = 12;

        const string FieldSep = "| ";

        static string ElapsedPlaceholder 
            => string.Empty.PadRight(ElapsedPad);

        static string FormatTs(DateTime ts)
            => ts.ToLexicalString().PadRight(TimeStampPad);

        static string Format(TimeSpan elapsed)
            => $"{elapsed.TotalMilliseconds}ms".PadRight(ElapsedPad);

        static string FormatName(string testName)
            => $"{testName}".PadRight(TestNamePad);

        static string FormatStatus(string status)
            => status.PadRight(12);

        static AppMsg PreCaseMsg(string testName, DateTime start)
        {
            var fields = items(
                FormatName(testName), 
                FormatStatus("executing"), 
                ElapsedPlaceholder, 
                FormatTs(start)
                );                

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
        }

        static AppMsg AftCaseMsg(string testName, TimeSpan elapsed, DateTime start, DateTime end)
        {
            var fields = items(
                FormatName(testName), 
                FormatStatus("executed"), 
                Format(elapsed), 
                FormatTs(start), 
                FormatTs(end),
                Format(end - start)
                );

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
        }

        static AppMsg AftUnitMsg(string hosturi, TimeSpan elapsed, DateTime start, DateTime end)
        {
            var fields = items(
                FormatName(hosturi), 
                FormatStatus("completed"), 
                Format(elapsed), 
                FormatTs(start), 
                FormatTs(end),
                Format(end - start)
                );

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
        }

        public Duration RunAction(IUnitTest unit, Action exec)
        {
            var messages = new List<AppMsg>();
            var clock = counter(false);
            var casename = unit.TestActionName();
            
            try
            {                
                unit.Configure(Config);     
                
                var tsStart = now();
                messages.Add(PreCaseMsg(casename, tsStart));                
                
                clock.Start();
                exec();
                clock.Stop();

                messages.AddRange(unit.DequeueMessages());
                messages.Add(AftCaseMsg(casename, clock.Time, tsStart, now()));

                var outcomes = unit.TakeOutcomes().ToArray();                
                if(outcomes.Length != 0)
                    Enqueue(outcomes);
                else
                    Enqueue(TestCaseRecord.Define(casename,true,clock.Time));                              

            }
            catch(Exception e)
            {
                clock.Stop();
                messages.AddRange(unit.DequeueMessages());                
                messages.AddRange(GetErrorMessages(casename,e));
                Enqueue(TestCaseRecord.Define(casename,false,clock.Time));                
            }
            finally
            {            
                print(messages);
            }
            return clock.Time;
        }

        void Run(bool concurrent, params string[] filters)
            => iter(Hosts(), h =>  Run(h,filters), concurrent);
        
        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods().Public().NonGeneric().WithArity(0);

        IEnumerable<AppMsg> GetErrorMessages(string name, Exception e)
        {
            if(e.InnerException is ClaimException claim)
                yield return claim.Message;
            
            else if(e.InnerException is AppException app)
                yield return app.Message;
            else                
                yield return messages.Unanticipated(e?.InnerException ?? e);

            yield return AppMsg.Error($"{name} failed.");
        }

        AppMsg[] CollectMessages(IUnitTest src, string testName, Duration runtime, Exception e = null)
        {
            var messages = new List<AppMsg>();
            messages.AddRange(src.DequeueMessages());
            if(e != null)
                messages.AddRange(GetErrorMessages(testName,e));
            else
                messages.Add(AppMsg.Info($"{testName} executed. {runtime}"));
            return messages.ToArray();
        }

        TestCaseRecord[] CollectOutcomes(IExplicitTest unit, string casename, Duration runtime, Exception e = null)
        {
            var outcomes = new List<TestCaseRecord>();
            if(e!= null)
                outcomes.Add(TestCaseRecord.Define(casename,false,runtime));
            else
            {
                outcomes.AddRange(unit.TakeOutcomes());
                if(outcomes.Count == 0)
                    outcomes.Add(TestCaseRecord.Define(casename,true,runtime));
            }
            return outcomes.ToArray();
        }

        Duration ExecExplicit(IExplicitTest unit, string hostpath, IList<TestCaseRecord> results)
        {
            var clock = counter(false);
            var messages = array<AppMsg>();
            var casename = unit.TestCaseName();

            try
            {
                clock.Start();
                unit.Execute();
                clock.Stop();

                messages = CollectMessages(unit, casename,clock);
                results.WithItems(CollectOutcomes(unit, casename, clock));                

            }
            catch(Exception e)
            {
                clock.Stop();
                messages = CollectMessages(unit, casename, clock, e);
                results.WithItems(CollectOutcomes(unit,casename, clock,e));
            }
            finally
            {            
                print(messages);
            }

            return clock;
        }

        Duration ExecCase(IUnitTest unit, MethodInfo testcase, IList<TestCaseRecord> results)
        {
            var exectime = Duration.Zero;
            var messages = new List<AppMsg>();
            var casename = testcase.TestCaseName();
            var clock = counter(false);

            try
            {
                var tsStart = now();
                messages.Add(PreCaseMsg(casename, tsStart));

                clock.Start();
                testcase.Invoke(unit,null);                    
                clock.Stop();

                messages.AddRange(unit.DequeueMessages());
                messages.Add(AftCaseMsg(casename, clock.Time, tsStart, now()));
                
                var outcomes = unit.TakeOutcomes().ToArray();
                if(outcomes.Length != 0)
                    results.WithItems(outcomes);
                else
                    results.Add(TestCaseRecord.Define(casename, true, clock.Time));
            }
            catch(Exception e)
            {                
                clock.Stop();
                messages.AddRange(unit.DequeueMessages());                
                messages.AddRange(GetErrorMessages(casename, e));
                results.Add(TestCaseRecord.Define(casename, false, clock.Time));                              
            }
            finally
            {            
                print(messages);
            }
            return exectime;
        }            

        protected TestApp()
        {
            Configure(Config.WithTrace());   
        }

        protected virtual string AppName
            => GetType().Assembly.GetSimpleName();

        /// <summary>
        /// When overriding, return true to signal that standard tests should also be executed
        /// </summary>
        protected virtual bool RunCustom()
            => true;

        void EmitLogs()
        {
            var basename = AppName;
            
            var benchmarks = TakeSortedBenchmarks();
            if(benchmarks.Any())
            {
                Log.LogBenchmarks(basename.Replace(".test",".bench"),benchmarks, LogWriteMode.Overwrite);
            }
            
            var results = TakeSortedResults();
            if(results.Any())
            {
                // Emit a unique file
                Log.LogTestResults(FolderName.Define("history"), basename, results, LogWriteMode.Create);
                
                // Overwrite the current test log file for the app
                Log.LogTestResults(basename, results, LogWriteMode.Overwrite);
            }
        }

        protected virtual void RunTests(params string[] filters)
        {
            try
            {            
                if(RunCustom())
                {
                    Run(false,filters);
                }
                EmitLogs();

            }
            catch (Exception e)
            {
                FlushMessages(e, Log.Test);
            }
        }

        public static void Run(params string[] args)
            => new A().RunTests();
    }
}