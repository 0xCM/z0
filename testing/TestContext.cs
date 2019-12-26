//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
            : base(random ?? Rng.XOrShift1024(Seed1024.TestSeed).ToPolyrand())
        {
            this.Config = config ?? TestConfigDefaults.Default();
        }

        protected static readonly N256 DefaultSampleNat = default;

        /// <summary>
        /// The default number of elements to be selected from some sort of stream
        /// </summary>
        protected const int DefaultSampleSize = Pow2.T08;

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

        public void Configure(ITestConfig config)
            => Config = config;

        protected override bool TraceEnabled
            => Config.TraceEnabled;

        protected virtual Interval<K> SampleDomain<K>()
            where K : unmanaged
                => RngDefaults.get<K>().SampleDomain;
                
        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int SampleCount
            => DefaultSampleSize;
        
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

        public TestCaseRecord ReportOutcome(string opname, bool succeeded, TimeSpan duration)
        {
            var record = TestCaseRecord.Define(opname,succeeded,duration);
            TestOutcomes.Enqueue(record);
            return record;
        }

        public BenchmarkRecord ReportBenchmark(string opname, long opcount, TimeSpan duration)
        {
            var record = BenchmarkRecord.Define(opname, opcount, duration);
            Enqueue(record);
            return record;
        }
    }
}