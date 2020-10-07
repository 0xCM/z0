//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public interface ITableSink<T> : IDataSink<T>
        where T : struct
    {
        void Deposit(ReadOnlySpan<T> src);
    }

    public interface ITableSink<H,T> : ITableSink<T>, IWfSink<H,T>
        where T : struct
        where H : struct, ITableSink<H,T>
    {

    }
}