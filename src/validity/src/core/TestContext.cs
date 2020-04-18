//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static Seed;

    public partial class TestContext<U> : ITestContext, ITestControl
    {
        public ITestContext Context {get;}

        public virtual IPolyrand Random {get;}
            =  Polyrand.WyHash64(PolySeed64.Seed00);

        public event Action<IAppMsg> Next;

        protected IAppMsgExchange Messages {get; private set;}

        Queue<TestCaseRecord> TestResults {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();

        protected TestContext()
        {
            this.Context = this;            
            // this.Random = random ?? Polyrand.WyHash64(PolySeed64.Seed00);
            this.Next += BlackHole;
            this.Messages = AppMessages.exchange();
            this.Messages.Next += Relay;
        }

        public virtual void Dispose()
            => OnDispose();

        protected virtual void OnDispose() 
        {

        }

        void BlackHole(IAppMsg msg) {}
                
        void Relay(IAppMsg msg)
            => Next(msg);

        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int RepCount
            => Context.RepCount;
        
        /// <summary>
        /// The number times to repeat an action
        /// </summary>
        protected virtual int CycleCount
            => Context.CycleCount;

        /// <summary>
        /// The number of times to repeat a cycle
        /// </summary>
        protected virtual int RoundCount
            => Context.RoundCount;

        /// <summary>
        /// The number of operations performed in a benchmarking expercise
        /// </summary>
        protected virtual int OpCount
            => RoundCount*CycleCount;
        
        public virtual bool Enabled 
            => Context.Enabled;

        protected void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Context.ReportBenchmark(name,opcount, duration);

    }
}