//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static BitVector<T> ToBitVector<T>(this BitSpan32 src)
            where T : unmanaged
                => src.Extract<T>();

        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this BitSpan32 src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
               => src.Extract<T>();

        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this BitSpan32 src, N8 n)
            => src.Extract<byte>();

        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this BitSpan32 src, N16 n)
            => src.Extract<ushort>();

        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this BitSpan32 src, N32 n)
            => src.Extract<uint>();

        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitSpan32 src, N64 n)
            => src.Extract<ulong>();
    }
}