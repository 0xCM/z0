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

        public IPolyrand Random {get;}

        public event Action<IAppMsg> Next;

        protected IAppMsgExchange Queue {get; private set;}

        Queue<TestCaseRecord> Outcomes {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();

        protected TestContext(IPolyrand random = null)
        {
            this.Context = this;            
            this.Random = random ?? Polyrand.WyHash64(PolySeed64.Seed00);
            this.Next += BlackHole;
            this.Queue = AppMessages.exchange();
            this.Queue.Next += Relay;
        }

        public Type HostType => typeof(U);

        public virtual void Dispose()
            => OnDispose();

        protected virtual void OnDispose() { }

        void BlackHole(IAppMsg msg) {}
                
        void Relay(IAppMsg msg)
            => Next(msg);

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
    }
}