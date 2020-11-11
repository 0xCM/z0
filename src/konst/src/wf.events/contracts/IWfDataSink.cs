//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfDataSink<H,T> : IDataSink<T>
        where T : struct
        where H : struct, IWfDataSink<H,T>
    {
        void Deposit(ReadOnlySpan<T> src);
    }
}