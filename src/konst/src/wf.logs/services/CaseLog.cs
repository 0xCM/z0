//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CaseLog : ICaseLog
    {
        readonly ICaseLog<TestCaseRecord> Log;

        [MethodImpl(Inline)]
        internal CaseLog(ICaseLog<TestCaseRecord> log)
            => Log = log;

        public void Dispose()
            => Log?.Dispose();

        public void Deposit(params TestCaseRecord[] src)
            => Log.Deposit(src);
    }
}