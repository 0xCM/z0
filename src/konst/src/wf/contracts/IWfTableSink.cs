//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public interface IWfTableSink : IWfSink, IWfTableWorker
    {

    }

    public interface IWfTableSink<T> : IWfSink<T>, IWfTableWorker<T>
        where T : struct, ITable
    {
        void Deposit(ReadOnlySpan<T> src);
    }

    public interface IWfTableSink<H,T> : IWfTableSink<T>, IWfSink<H,T>
        where T : struct, ITable
        where H : struct, IWfTableSink<H,T>
    {

    }
}