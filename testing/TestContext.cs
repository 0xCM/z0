//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    public abstract class TestContext<T> : Context<T>, ITestContext
        where T : TestContext<T>
    {
        public TestContext(ITestConfig config = null, IPolyrand random = null)
            //: base(random ?? Rng.XOrShift1024(Seed1024.TestSeed).ToPolyrand())
            : base(random ?? Rng.WyHash64(Seed64.Seed00))
        {
            this.Config = config ?? TestConfigDefaults.Default();
        }

        /// <summary>
        /// The default number of times a randomized test case should be repeated
        /// </summary>
        protected const int DefaultRepCount = Pow2.T06;

        /// <summary>
        /// The default number times to repeat an activity
        /// </summary>
        protected const int DefaltCycleCount = Pow2.T03;

        /// <summary>
        /// The default number times to repeat a cycle
        /// </summary>
        protected const int DefaultRoundCount = Pow2.T01;

        public ITestConfig Config {get; private set;}

        Queue<TestCaseRecord> TestOutcomes {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();

        public void Configure(ITestConfig config)
            => Config = config;

        protected override bool TraceEnabled
            => Config.TraceEnabled;
                
        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int RepCount
            => DefaultRepCount;
        
        /// <summary>
        /// The number times to repeat an action
        /// </summary>
        protected virtual int CycleCount
            => DefaltCycleCount;

        /// <summary>
        /// The number of times to repeat a cycle
        /// </summary>
        protected virtual int RoundCount
            => DefaultRoundCount;

        /// <summary>
        /// The number of operations performed in a benchmarking expercise
        /// </summary>
        protected virtual int OpCount
            => RoundCount*CycleCount;
        
        public virtual bool Enabled 
            => true;

        public IEnumerable<TestCaseRecord> TakeOutcomes()
        {
            while(TestOutcomes.Any())
                yield return TestOutcomes.Dequeue();
        }

        public IEnumerable<BenchmarkRecord> TakeBenchmarks()
        {
            while(Benchmarks.Any())
                yield return Benchmarks.Dequeue();
        }

        public TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration)
        {
            var record = TestCaseRecord.Define(casename,succeeded,duration);
            TestOutcomes.Enqueue(record);
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