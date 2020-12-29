//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISpanBuffer : INullity, IMeasured
    {

    }

    [Free]
    public interface ISpanBuffer<T> : ISpanBuffer, IIndex<T>
    {

    }

    [Free]
    public interface ISpanBuffer<H,T> : ISpanBuffer<T>
        where H : struct, ISpanBuffer<H,T>
    {
        H Refresh(T[] src);
    }
}