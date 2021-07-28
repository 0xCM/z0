//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITensor<T> : IPrimitive<T>
        where T : unmanaged
    {
        byte Arity {get;}

        TypeKind IPrimitive.TypeKind
            => TypeKind.Tensor;
    }

    [Free]
    public interface ITensor<N,T> : ITensor<T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        byte ITensor<T>.Arity
            => Typed.nat8u<N>();

        BitWidth IPrimitive.StorageWidth
            => Arity*core.width<T>();
    }
}