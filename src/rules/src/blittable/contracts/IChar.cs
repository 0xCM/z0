//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IChar : IPrimitive
    {
        TypeKind IPrimitive.TypeKind
            => TypeKind.Char;
    }

    [Free]
    public interface IChar<T> : IChar, IPrimitive<T>
        where T : unmanaged
    {


    }

    [Free]
    public interface IChar<F,T> : IChar<T>
        where T : unmanaged
        where F : unmanaged, IChar<F,T>
    {

    }
}