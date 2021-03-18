//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfSink<H,T> : ISink<T>
        where H : struct, IWfSink<H,T>
    {
        void Deposit(ReadOnlySpan<T> src);
    }
}