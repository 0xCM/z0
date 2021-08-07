//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBlittable
    {
        Span<byte> Edit {get;}
        ReadOnlySpan<byte> View {get;}
    }

    [Free]
    public interface IBlittable<T> : IBlittable
        where T : unmanaged, IBlittable<T>
    {

    }
}