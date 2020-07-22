//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;

    using static Konst;

    /// <summary>
    /// Base type for test applications
    /// </summary>
    /// <typeparam name="A">The concrete subtype</typeparam>
    public abstract partial class TestApp<A> : TestContext<A>
        where A : TestApp<A>, new()
    {
        const bool InDiagnosticMode = false;
        
        protected virtual string AppName
            => GetType().Assembly.GetSimpleName();

        protected TestApp()
        {
            CaseLog = CaseLog.create(AppPaths.CaseLogPath);
            OnDispose += HandleDispose;
        }

        void HandleDispose()
        {
            CaseLog.Dispose();
        }

        protected IAppMsgSink Log 
            => this.MessageLog();
        
        ConcurrentQueue<TestCaseRecord> TestResultQueue {get;}
            = new ConcurrentQueue<TestCaseRecord>();

        ConcurrentQueue<BenchmarkRecord> BenchmarkQueue {get;}
            = new ConcurrentQueue<BenchmarkRecord>();
    }
}