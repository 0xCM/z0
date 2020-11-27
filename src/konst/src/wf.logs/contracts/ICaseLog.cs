//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICaseLog : IDisposable
    {
        void Deposit(params TestCaseRecord[] src);
    }

    public interface ICaseLog<R> : ICaseLog
        where R : ITabular
    {
        void Deposit(params R[] src);

        void ICaseLog.Deposit(params TestCaseRecord[] src)
            => Deposit(src);
    }
}