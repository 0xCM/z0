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

    using static Konst;
    using static Root;

    /// <summary>
    /// Base type for test applications
    /// </summary>
    /// <typeparam name="A">The concrete subtype</typeparam>
    public abstract class TestApp<A> : TestContext<A>
        where A : TestApp<A>, new()
    {
        protected IAppMsgSink Log => this.MessageLog();
        
        ConcurrentQueue<TestCaseRecord> TestResultQueue {get;}
            = new ConcurrentQueue<TestCaseRecord>();

        ConcurrentQueue<BenchmarkRecord> BenchmarkQueue {get;}
            = new ConcurrentQueue<BenchmarkRecord>();

        void PostTestResults(IEnumerable<TestCaseRecord> outcomes)
            => TestResultQueue.Enqueue(outcomes);

        void PostTestResult(TestCaseRecord outcome)
            => TestResultQueue.Enqueue(outcome);

        void PostBenchResult(IEnumerable<BenchmarkRecord> outcomes)
            => BenchmarkQueue.Enqueue(outcomes);

        BenchmarkRecord[] TakeSortedBenchmarks()
        {
            var records = BenchmarkQueue.ToArray();
            BenchmarkQueue.Clear();
            Array.Sort(records);
            return records;
        }

        TestCaseRecord[] TakeSortedResults()
        {
            static TestCaseRecord[] Sort(IEnumerable<TestCaseRecord> src)
                => src.OrderBy(x => x.Case).Where(x => x.Status == 0).Concat(src.Where(x => x.Status != 0)).ToArray();

            var results = Sort(TestResultQueue);
            TestResultQueue.Clear();
            return results;
        }

        IEnumerable<Type> CandidateTypes()
            =>  from t in typeof(A).Assembly.Types().Realize<IUnitTest>()
                where t.IsConcrete() && t.Untagged<IgnoreAttribute>()
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


        void Run(Type host, IUnitTest unit)
        {
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
                    Root.iter(Tests(host), t =>  execTime += ExecCase(unit, t, results));   
                    PostBenchResult(unit.TakeBenchmarks().ToArray());
                }

                clock.Stop();
                
                var hosturi = OpUriBuilder.HostUri(host);
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

        public void Run(Type host, string[] filters)
        {        
            if(!HasAny(host,filters))
                return;            

            using var unit = host.Instantiate<IUnitTest>();

            if(unit.Enabled)
                Run(host, unit);            
        }

        const int CasePad = (int)((ulong)TestCaseField.Case >> 32);
        
        const int ExecutedPad = (int)((ulong)TestCaseField.Executed >> 32);

        const int DurationPad = (int)((ulong)TestCaseField.Duration >> 32);

        const int StatusPad = (int)((ulong)TestCaseField.Status >> 32);

        const string FieldSep = "| ";

        static string DurationPlaceholder 
            => string.Empty.PadRight(DurationPad);

        static string FormatTs(DateTime ts)
            => ts.ToLexicalString().PadRight(ExecutedPad);

        static string Format(TimeSpan elapsed)
            => $"{elapsed.TotalMilliseconds} ms".PadRight(DurationPad);

        static string FormatName(string testName)
            => $"{testName}".PadRight(CasePad);

        static string FormatStatus(string status)
            => status.PadRight(StatusPad);

        static AppMsg PreCase(string testName, DateTime start)
        {
            var fields = Arrays.from(
                FormatName(testName), 
                FormatStatus("executing"), 
                DurationPlaceholder, 
                FormatTs(start)
                );                

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
        }

        static AppMsg PostCase(string testName, TimeSpan elapsed, DateTime start, DateTime end)
        {
            var fields = Arrays.from(
                FormatName(testName), 
                FormatStatus("executed"), 
                Format(elapsed), 
                FormatTs(start), 
                FormatTs(end),
                Format(end - start)
                );

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
        }

        static AppMsg PostUnit(string hosturi, TimeSpan elapsed, DateTime start, DateTime end)
        {
            var fields = Arrays.from(
                FormatName(hosturi), 
                FormatStatus("completed"), 
                Format(elapsed), 
                FormatTs(start), 
                FormatTs(end),
                Format(end - start)
                );

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
        }

        string TestActionName
        {
            get 
            {
                var owner = Identify.Owner(GetType());
                var hostname = GetType().Name;
                var opname = "action";         
                return $"{owner}/{hostname}/{opname}";
            }
        }

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
                messages.AddRange(CreateErrorMessages(casename,e));
                PostTestResult(TestCaseRecord.Define(casename,false,clock.Time));                
            }
            finally
            {            
                term.print(messages);
            }
            return clock.Time;
        }

        
        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods().Public().NonGeneric().WithArity(0);

        IEnumerable<IAppMsg> CreateErrorMessages(string name, Exception e)
        {
            if(e.InnerException is ClaimException claim)
                yield return claim.Message;            
            else if(e.InnerException is AppException app)
                yield return app.Message;
            else if(e.InnerException != null)               
                yield return AppMsg.NoCaller($"{e}",AppMsgKind.Error);
            else
                yield return AppMsg.NoCaller($"{name} failed {e}", AppMsgKind.Error);
        }

        IAppMsg[] CollectMessages(IUnitTest unit, string testName, Duration runtime, Exception e = null)
        {
            var messages = new List<IAppMsg>();
            var control = unit as ITestQueue;
            messages.AddRange(unit.Dequeue());
            if(e != null)
                messages.AddRange(CreateErrorMessages(testName,e));
            else
                messages.Add(AppMsg.Info($"{testName} executed. {runtime}"));
            return messages.ToArray();
        }

        TestCaseRecord[] CollectTestResults(IExplicitTest unit, string casename, Duration runtime, Exception e = null)
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

        static string TestCaseName(IExplicitTest unit)
        {
            var owner = Identify.Owner(unit.GetType());
            var hostname = unit.GetType().Name;
            var opname = "explicit";
            return $"{owner}/{hostname}/{opname}";
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
                results.WithItems(CollectTestResults(unit, casename, clock));                

            }
            catch(Exception e)
            {
                clock.Stop();
                messages = CollectMessages(unit, casename, clock, e);
                results.WithItems(CollectTestResults(unit,casename, clock,e));
            }
            finally
            {            
                Log.Deposit(messages);                
                Root.iter(messages.Where(m => !m.Displayed), term.print);
            }

            return clock;
        }

        Duration ExecCase(IUnitTest unit, MethodInfo method, IList<TestCaseRecord> cases)
        {
            var exectime = Duration.Zero;
            var casename = OpUriBuilder.TestCase(method);

            var clock = counter(false);

            var collected = new List<IAppMsg>();
            try
            {
                var tsStart = Time.now();
                collected.Add(PreCase(casename, tsStart));

                clock.Start();
                method.Invoke(unit,null);                    
                clock.Stop();

                collected.AddRange(unit.Dequeue());
                collected.Add(PostCase(casename, clock.Time, tsStart, Time.now()));
                
                var outcomes = unit.TakeOutcomes().ToArray();
                if(outcomes.Length != 0)
                    cases.WithItems(outcomes);
                else
                    cases.Add(TestCaseRecord.Define(casename, true, clock.Time));
            }
            catch(Exception e)
            {                
                clock.Stop();
                collected.AddRange(unit.Dequeue());                
                collected.AddRange(CreateErrorMessages(casename, e));             
                cases.Add(TestCaseRecord.Define(casename, false, clock.Time));                              
            }
            finally
            {     
                
                Log.Deposit(collected);                
                Root.iter(collected.Where(m => !m.Displayed), term.print);       

            }

            return exectime;
        }            

        protected virtual string AppName
            => GetType().Assembly.GetSimpleName();

        static FilePath LogTestResults(FolderName subdir, string basename,  TestCaseRecord[] records, LogWriteMode mode, bool header = true, char delimiter = Chars.Pipe)
        {
            if(records.Length == 0)
                return FilePath.Empty;
            
            return TestLog.Create().Write(records, subdir, basename, mode, delimiter, header, FileExtension.Define("csv"));
        }

        static FilePath LogBenchmarks<R>(string basename, R[] records, LogWriteMode mode = LogWriteMode.Create, bool header = true, char delimiter = Chars.Pipe)
            where R : ITabular
        {
            if(records.Length == 0)
                return FilePath.Empty;
                        
            return Z0.Log.BenchLog.Write(records, FolderName.Empty, basename, mode, delimiter, header, FileExtension.Define("csv"));
        }

        FilePath LogTestResults2(string basename, TestCaseRecord[] records, LogWriteMode mode, bool header = true, char delimiter = Chars.Pipe)
                => LogTestResults(AppPaths.TestResultFolder, basename, records, mode, header, delimiter);

        void EmitLogs()
        {
            var basename = AppName;
            
            var benchmarks = TakeSortedBenchmarks();
            if(benchmarks.Any())
            {
                LogBenchmarks(basename.Replace(".test",".bench"),benchmarks, LogWriteMode.Overwrite);
            }
            
            var results = TakeSortedResults();
            if(results.Any())
            {
                // Emit a unique file
                LogTestResults(FolderName.Define("history"), basename, results, LogWriteMode.Create);
                
                // Overwrite the current test log file for the app
                LogTestResults2(basename, results, LogWriteMode.Overwrite);
            }
        }

        void Run(bool concurrent, params string[] filters)
        {
            var hosts = Hosts().ToArray();
            iter(hosts, h =>  Run(h,filters), concurrent);
        }

        protected virtual void RunTests(params string[] filters)
        {
            try            
            {  
                Context.AppPaths.TestErrorPath.Delete();
                Context.AppPaths.AppStandardOutPath.Delete();          
                
                Run(false,filters);

                EmitLogs();
            }
            catch (Exception e)
            {
                Flush(e, TestLog.Create());
            }
        }

        public static void Run(params string[] args)
            => new A().RunTests();
    }
}