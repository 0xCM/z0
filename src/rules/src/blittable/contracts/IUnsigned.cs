//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IUnsigned<T> : IPrimitive<T>
        where T : unmanaged
    {
        TypeKind IPrimitive.TypeKind
            => TypeKind.Tensor;
    }
}