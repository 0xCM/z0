//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface IBitVector : IPrimitive
    {
        BlittableKind IPrimitive.TypeKind
            => BlittableKind.BitVector;
    }
    [Free]
    public interface IBitVector<T> : IBitVector, IPrimitive<T>
        where T : unmanaged
    {

    }

    [Free]
    public interface IScalarBits<T> : IBitVector<T>
        where T : unmanaged
    {
        bit this[byte i] {get;set;}
    }

    // [Free]
    // public interface IBitVector : IPrimitive
    // {
    //     Span<bit> Edit {get;}

    //     ReadOnlySpan<bit> View {get;}

    //     BlittableKind IPrimitive.TypeKind
    //         => BlittableKind.BitVector;

    //     BitWidth IPrimitive.ContentWidth
    //         => View.Length*8;

    //     BitWidth IPrimitive.StorageWidth
    //         => View.Length*8;
    // }

    // [Free]
    // public interface IBitVector<T> : IBitVector
    //     where T : unmanaged
    // {
    //     T Storage {get;}

    //     BitWidth IPrimitive.StorageWidth
    //         => core.width<T>();
    // }
}