//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    public class ComparisonContext : IComparisonContext
    {
        public Type HostType {get;}

        public IPolyrand Random {get;}
        
        IAppMsgSink Sink {get;}

        Action<TestCaseOutcome> Relay {get;}
        
        ConcurrentQueue<ComparisonResult> Outcomes {get;}

        public static IComparisonContext From(ITestContext context)
            => new ComparisonContext(context.HostType, context as IAppMsgSink, context.Random, context.ReportOutcome);

        public static IComparisonContext Define(Type host, IAppMsgSink sink, IPolyrand random)
            => new ComparisonContext(host,sink, random);

        public ComparisonContext(Type host, IAppMsgSink sink, IPolyrand random, Action<TestCaseOutcome> relay = null)
        {
            this.HostType = host;
            this.Sink = sink;
            this.Random = random;
            this.Outcomes = new ConcurrentQueue<ComparisonResult>();
            this.Relay = relay ?? BlackHole;
        }

        public void Notify(AppMsg msg)        
            => Sink?.Notify(msg);

        void BlackHole(TestCaseOutcome outcome) {}

        public void ReportOutcome(string casename, bool succeeded, TimeSpan duration, AppMsg msg = null)    
        {
            var result = new ComparisonResult(casename, succeeded, duration, msg);
            Outcomes.Enqueue(result);
            Relay(result);
        }
    }
}