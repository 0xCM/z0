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

        protected readonly IAppMsgSink Log;

        protected readonly CaseLog CaseLog;

        protected virtual string AppName {get;}

        protected TestApp()
        {
            CaseLog = CaseLogs.create(TestLogPaths.CaseLogPath);
            OnDispose += CaseLog.Dispose;
            AppName = GetType().Assembly.GetSimpleName();
            Log = new AppMsgLog(TestLogPaths.TestStatusLogPath, TestLogPaths.TestErrorLogPath);
        }

        ConcurrentQueue<TestCaseRecord> TestResultQueue {get;}
            = new ConcurrentQueue<TestCaseRecord>();

        ConcurrentQueue<BenchmarkRecord> BenchmarkQueue {get;}
            = new ConcurrentQueue<BenchmarkRecord>();
    }
}