//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Literals;

    partial class BitVector
    {
        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline),TestC]
        public static bit testc(BitVector8 src)
            => (byte.MaxValue & src.Data) == byte.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline),TestC]
        public static bit testc(BitVector16 src)
            => (ushort.MaxValue & src.Data) == ushort.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline),TestC]
        public static bit testc(BitVector32 src)
            => (uint.MaxValue & src.Data) == uint.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline),TestC]
        public static bit testc(BitVector64 src)
            => (ulong.MaxValue & src.Data) == ulong.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit testc<T>(BitVector<T> src)
            where T : unmanaged
                => gmath.eq(gmath.and(maxval<T>(), src.Data), maxval<T>());

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline),TestC]
        public static bit testc<N,T>(BitVector<N,T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.eq(gmath.and(maxval<T>(), src.Data), maxval<T>());

        [MethodImpl(Inline),TestC]
        public static bit testc<N,T>(BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vtestc(src.Data);
 
    }
}