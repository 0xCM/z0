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
        BitWidth Width {get;}

        Span<byte> Edit {get;}

        ReadOnlySpan<byte> View {get;}
    }

    [Free]
    public interface IBlittable<T> : IBlittable
        where T : unmanaged
    {
        T Data {get;}
    }

    [Free]
    public interface IBlittable<T,K> : IBlittable<T>
        where T : unmanaged
        where K : unmanaged
    {
        K Kind {get;}
    }
}