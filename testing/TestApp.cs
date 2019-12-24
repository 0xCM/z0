//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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

        protected TestCaseRecord[] DequeueResults(Func<IEnumerable<TestCaseRecord>, IEnumerable<TestCaseRecord>> sorter)
        {
            var results = sorter(TestResultQueue).ToArray();
            TestResultQueue.Clear();
            return results;
        }

        IEnumerable<Type> CandidateTypes()
            => typeof(A).Assembly.Types().Realize<IUnitTest>().Where(t => t.ContainsGenericParameters == false);        
        
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
        void Run(Type host, string[] filters)
        {        

            if(!HasAny(host,filters))
                return;

            var results = new List<TestCaseRecord>();
            try
            {
                var execTime = Duration.Zero;
                var runtimer = stopwatch();

                Trace(AppMsg.Define($"Creating unit {host.Name}", SeverityLevel.Babble));
                var instance = host.CreateInstance<IUnitTest>();
                instance.Configure(Config);                

                var hostpath = host.DisplayName();
                if(instance.Enabled)
                    iter(Tests(host), t =>  execTime += Run(instance, hostpath, t, results));                
                Mark(instance.Benchmarks);
                
                print(AppMsg.Define($"{host.Name} exectime {execTime.Ms} ms, runtime = {snapshot(runtimer).Ms} ms", SeverityLevel.Info));

            }
            catch(Exception e)
            {
                error($"Host execution failed: {e}", this);
            }  

            Enqueue(results);
            
        }

        void Run(bool concurrent, params string[] filters)
            => iter(Hosts(), h =>  Run(h,filters), concurrent);

        protected virtual bool PersistResults
            => false;
        
        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods().Public().NonGeneric().WithParameterCount(0);

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
                messages.AddRange(unit.DequeueMessages());
                messages.Add(AppMsg.Define($"{testName} executed. {exectime.Ms}ms", SeverityLevel.Info));
                
                var reported = unit.PopOutcomes().ToArray();
                if(reported.Length != 0)
                    results.AddRange(reported);
                else
                    results.Add(TestCaseRecord.Define(testName,true,exectime));
            }
            catch(Exception e)
            {                
                exectime = snapshot(sw);
                messages.AddRange(unit.DequeueMessages());                
                
                if(e.InnerException is ClaimException claim)
                    messages.Add(claim.Message);
                else if(e.InnerException is AppException app)
                    messages.Add(app.Message);
                else
                    messages.Add(ErrorMessages.Unanticipated(e ?? e.InnerException));

                messages.Add(AppMsg.Define($"{testName} failed. {exectime.Ms}ms", SeverityLevel.Error));  
                results.Add(TestCaseRecord.Define(testName,false,exectime));
                              
            }
            finally
            {            
                print(messages);
                if(PersistResults)
                    log(messages, LogArea.Test);
            }
            return exectime;
        }            

        protected TestApp()
        {
            Configure(Config.WithTrace());   
        }

        protected virtual string AppName
            => GetType().Assembly.GetSimpleName();

        static IEnumerable<TestCaseRecord> Sort(IEnumerable<TestCaseRecord> src)
            => src.OrderBy(x => x.Operation).Where(x => !x.Succeeded).Concat(src.Where(x => x.Succeeded));

        static IEnumerable<BenchmarkRecord> Sort(IEnumerable<BenchmarkRecord> src)
            => src.OrderBy(x => x.Operation);

        void EmitLogs()
        {
            var basename = AppName;
            
            var timings = DequeueTimings(Sort);
            if(timings.Any())
                Log.LogBenchmarks(basename.Replace(".test",".bench"),timings, LogWriteMode.Overwrite);
            
            var results = DequeueResults(Sort);
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
                Run(false,filters);
                EmitLogs();

            }
            catch (Exception e)
            {
                NotifyError(e);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunTests();
    }
}

namespace Z0.Test
{
    //public static class X {}
}