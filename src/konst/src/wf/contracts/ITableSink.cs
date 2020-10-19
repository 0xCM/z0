//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableSink<H,T> : IDataSink<T>
        where T : struct
        where H : struct, ITableSink<H,T>
    {
        void Deposit(ReadOnlySpan<T> src);
    }
}