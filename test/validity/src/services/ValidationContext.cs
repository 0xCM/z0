//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    public class ValidationContext : IValidationContext
    {
        public Type HostType {get;}

        public IPolyrand Random {get;}
        
        IAppMsgSink Sink {get;}

        Action<TestCaseOutcome> Relay {get;}
        
        ConcurrentQueue<SFCaseResult> Outcomes {get;}

        public ITestContext Context => this;

        public bool Enabled => true;

        public static IValidationContext From(ITestContext context)
            => new ValidationContext(context.HostType, context as IAppMsgSink, context.Random, context.ReportOutcome);

        public ValidationContext(Type host, IAppMsgSink sink, IPolyrand random, Action<TestCaseOutcome> relay = null)
        {
            this.HostType = host;
            this.Sink = sink;
            this.Random = random;
            this.Outcomes = new ConcurrentQueue<SFCaseResult>();
            this.Relay = relay ?? BlackHole;
        }

        public void Deposit(IAppMsg msg)        
            => Sink?.Deposit(msg);

        void BlackHole(TestCaseOutcome outcome) {}

        public void ReportOutcome(string casename, bool succeeded, TimeSpan duration)    
        {
            var result = new SFCaseResult(casename, succeeded, duration);
            Outcomes.Enqueue(result);
            Relay(result);
        }

        public void ReportBenchmark(string name, long opcount, TimeSpan duration)
        {}

        public void Dispose()
        {
            
        }
    }
}