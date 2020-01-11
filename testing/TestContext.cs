//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public abstract class TestContext<T> : Context<T>, ITestContext
        where T : TestContext<T>
    {
        protected TestContext(ITestConfig config = null, IPolyrand random = null)
            : base(random ?? Rng.WyHash64(Seed64.Seed00))
        {
            this.Config = config ?? TestConfigDefaults.Default();
        }

        protected TestContext(IPolyrand random)
            : base(random)
        {
            this.Config = TestConfigDefaults.Default();
        }

        public ITestConfig Config {get; private set;}

        Queue<TestCaseRecord> Outcomes {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();

        public void Configure(ITestConfig config)
            => Config = config;
                
        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int RepCount
            => Pow2.T06;
        
        /// <summary>
        /// The number times to repeat an action
        /// </summary>
        protected virtual int CycleCount
            => Pow2.T03;

        /// <summary>
        /// The number of times to repeat a cycle
        /// </summary>
        protected virtual int RoundCount
            => Pow2.T01;

        /// <summary>
        /// The number of operations performed in a benchmarking expercise
        /// </summary>
        protected virtual int OpCount
            => RoundCount*CycleCount;
        
        public virtual bool Enabled 
            => true;

        int ITestContext.RepCount 
            => RepCount;

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        [MethodImpl(Inline)]
        public string CaseName(IFunc f)
            => $"{GetType().Name}/{f.Moniker}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        [MethodImpl(Inline)]
        public string CaseName(string fullname)
            => $"{GetType().Name}/{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        [MethodImpl(Inline)]
        protected string CaseName<C>(string root, C t = default)
            => $"{GetType().Name}/{root}_{primalsig(t)}";

        [MethodImpl(Inline)]
        protected string CaseName<W,C>(string root, W w = default, C t = default)
            where W : unmanaged, ITypeNat
            where C : unmanaged
                => $"{GetType().Name}/{moniker(root,w,t)}";

        public IEnumerable<TestCaseRecord> TakeOutcomes()
        {
            while(Outcomes.Any())
                yield return Outcomes.Dequeue();
        }

        public IEnumerable<BenchmarkRecord> TakeBenchmarks()
        {
            while(Benchmarks.Any())
                yield return Benchmarks.Dequeue();
        }

        public TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration)
        {
            var record = TestCaseRecord.Define(casename,succeeded,duration);
            Outcomes.Enqueue(record);
            return record;
        }

        public BenchmarkRecord ReportBenchmark(string name, long opcount, TimeSpan duration)
        {
            var record = BenchmarkRecord.Define(name, opcount, duration);
            Benchmarks.Enqueue(record);
            return record;
        }
    }
}