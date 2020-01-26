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
            static IEnumerable<BenchmarkRecord> Sort(IEnumerable<BenchmarkRecord> src)
                => src.OrderBy(x => x.Operation);
            
            var benchmarks = Sort(BenchmarkQueue).ToArray();
            BenchmarkQueue.Clear();
            return benchmarks;
        }

        protected TestCaseRecord[] TakeSortedResults()
        {
            static IEnumerable<TestCaseRecord> Sort(IEnumerable<TestCaseRecord> src)
                => src.OrderBy(x => x.Operation).Where(x => !x.Succeeded).Concat(src.Where(x => x.Succeeded));

            var results = Sort(TestResultQueue).ToArray();
            TestResultQueue.Clear();
            return results;
        }

        IEnumerable<Type> CandidateTypes()
            =>  from t in typeof(A).Assembly.Types().Realize<IUnitTest>()
                where t.Reified() && t.Unattributed<IgnoreAttribute>()
                select t;
        
        IEnumerable<Type> Hosts()
            => CandidateTypes().Concrete().OrderBy(t => t.DisplayName());

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

            var results = new List<TestCaseRecord>();
            var unit = default(IUnitTest);
            try
            {
                var execTime = Duration.Zero;
                var runtimer = stopwatch();
                var name = host.DisplayName();

                Trace(AppMsg.Define($"Creating unit {host.Name}", SeverityLevel.Babble));
                unit = host.CreateInstance<IUnitTest>();
                unit.Configure(Config);                

                if(unit.Enabled)
                    iter(Tests(host), t =>  execTime += Run(unit, name, t, results));                
                Enqueue(unit.TakeBenchmarks().ToArray());
                
                print(AppMsg.Define($"{host.Name} exectime {execTime.Ms} ms, runtime = {snapshot(runtimer).Ms} ms", SeverityLevel.Info));

            }
            catch(Exception e)
            {
                errout($"Host execution failed: {e}", this);
            }  
            finally
            {
                Enqueue(results);
                if(unit is IDisposable d)
                    d.Dispose();
            }
        }

        public Duration RunAction(IUnitTest unit, Action exec)
        {
            var messages = new List<AppMsg>();
            var clock = counter(false);
            var testName = $"{unit.GetType().DisplayName()}/action";
            
            try
            {                
                unit.Configure(Config);                  
                messages.Add(AppMsg.Define($"{testName} executing", SeverityLevel.HiliteBL));                
                
                clock.Start();
                exec();
                clock.Stop();

                messages.AddRange(unit.DequeuePosts());
                messages.Add(AppMsg.Define($"{testName} executed. {clock.Time.TotalMilliseconds}ms", SeverityLevel.Info));

                var outcomes = unit.TakeOutcomes().ToArray();                
                if(outcomes.Length != 0)
                    Enqueue(outcomes);
                else
                    Enqueue(TestCaseRecord.Define(testName,true,clock.Time));                              

            }
            catch(Exception e)
            {
                clock.Stop();
                messages.AddRange(unit.DequeuePosts());                
                messages.AddRange(GetErrorMessages(testName,e));
                Enqueue(TestCaseRecord.Define(testName,false,clock.Time));                
            }
            finally
            {            
                print(messages);
            }
            return clock.Time;
        }

        void Run(bool concurrent, params string[] filters)
            => iter(Hosts(), h =>  Run(h,filters), concurrent);

        protected virtual bool PersistResults
            => false;
        
        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods().Public().NonGeneric().WithArity(0);

        IEnumerable<AppMsg> GetErrorMessages(string name, Exception e)
        {
            if(e.InnerException is ClaimException claim)
                yield return claim.Message;
            
            else if(e.InnerException is AppException app)
                yield return app.Message;
            else
                yield return ErrorMessages.Unanticipated(e ?? e.InnerException);

            yield return AppMsg.Define($"{name} failed.", SeverityLevel.Error);
        }

        Duration Run(IUnitTest unit, string hostpath, MethodInfo test, IList<TestCaseRecord> results)
        {
            var exectime = Duration.Zero;
            var messages = new List<AppMsg>();
            var testName = $"{hostpath}/{test.DisplayName()}";
            var sw = stopwatch(false);
            try
            {
                messages.Add(AppMsg.Define($"{testName} executing", SeverityLevel.HiliteBL));                
                sw.Start();
                test.Invoke(unit,null);                    
                exectime = snapshot(sw);
                messages.AddRange(unit.DequeuePosts());
                messages.Add(AppMsg.Define($"{testName} executed. {exectime.Ms}ms", SeverityLevel.Info));
                
                var outcomes = unit.TakeOutcomes().ToArray();
                if(outcomes.Length != 0)
                    results.AppendRange(outcomes);
                else
                    results.Add(TestCaseRecord.Define(testName,true,exectime));
            }
            catch(Exception e)
            {                
                exectime = snapshot(sw);
                messages.AddRange(unit.DequeuePosts());                
                messages.AddRange(GetErrorMessages(testName,e));
                results.Add(TestCaseRecord.Define(testName,false,exectime));
                              
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
                PostError(e);
            }
        }

        public static void Run(params string[] args)
            => new A().RunTests();
    }
}

namespace Z0.Test
{
    //public static class X {}
}