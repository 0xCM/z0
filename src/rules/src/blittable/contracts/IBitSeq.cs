//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBitSeq : IPrimitive
    {
        Span<byte> Edit {get;}

        ReadOnlySpan<byte> View {get;}

        TypeKind IPrimitive.TypeKind
            => TypeKind.Sequence;

        BitWidth IPrimitive.ContentWidth
            => View.Length*8;

        BitWidth IPrimitive.StorageWidth
            => View.Length*8;
    }

    [Free]
    public interface IBitSeq<T> : IBitSeq
        where T : unmanaged
    {
        T Storage {get;}


        BitWidth IPrimitive.StorageWidth
            => core.width<T>();
    }
}