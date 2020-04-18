//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

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

        public void Measure<T>(UnaryOp<T> f, UnaryOp<T> cf, string opname) where T : unmanaged
        {
            throw new NotImplementedException();
        }

        public void Measure<T>(BinaryOp<T> cf, BinaryOp<T> f, string opname) where T : unmanaged
        {
            throw new NotImplementedException();
        }

        public void CheckAction(Action f, OpIdentity id)
        {
            throw new NotImplementedException();
        }

        public void CheckAction(Action f, string name)
        {
            throw new NotImplementedException();
        }

        public void trace(IAppMsg msg)
        {
            throw new NotImplementedException();
        }

        public void trace(object msg, [CallerMemberName] string caller = null)
        {
            throw new NotImplementedException();
        }

        public void trace(string title, object msg, AppMsgColor color, [CallerMemberName] string caller = null)
        {
            throw new NotImplementedException();
        }

        public void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [CallerMemberName] string caller = null)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<IAppMsg> Dequeue()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<IAppMsg> Flush(Exception e)
        {
            throw new NotImplementedException();
        }

        public void Flush(Exception e, IAppMsgSink target)
        {
            throw new NotImplementedException();
        }

        public void Emit(FilePath dst)
        {
            throw new NotImplementedException();
        }

        public void NotifyConsole(IAppMsg msg)
        {
            throw new NotImplementedException();
        }

        public void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
        {
            throw new NotImplementedException();
        }
    }
}