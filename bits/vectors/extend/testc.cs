//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class BitVectorX
    {
        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bit TestC(this BitVector8 src)
            => (byte.MaxValue & src.data) == byte.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bit TestC(this BitVector16 src)
            => (ushort.MaxValue & src.data) == ushort.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bit TestC(this BitVector32 src)
            => (uint.MaxValue & src.data) == uint.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bit TestC(this BitVector64 src)
            => (ulong.MaxValue & src.data) == ulong.MaxValue;

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bit TestC<T>(this BitVector<T> src)
            where T : unmanaged
                => gmath.eq(gmath.and(maxval<T>(), src.data), maxval<T>());

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bit TestC<N,T>(this BitVector<N,T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.eq(gmath.and(maxval<T>(), src.data), maxval<T>());

        [MethodImpl(Inline)]
        public static bit TestC<N,T>(this BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vtestc(src.data);
    }
}