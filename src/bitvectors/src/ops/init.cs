//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class BitVector
    {
        /// <summary>
        /// Initializes a generic bitvector with a supplied value
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitVector<T> init<T>(T src)
            where T : unmanaged
                => new BitVector<T>(src);

        /// <summary>
        /// Initializes a natural bitvector over a primal type
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<W,T> init<W,T>(T src, W w = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => new BitVector<W,T>(src);

        /// <summary>
        /// Initializes a full-width 128-bit bitvector
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N128,T> init<T>(Vector128<T> src)
            where T : unmanaged
                => new BitVector128<N128,T>(src);

        /// <summary>
        /// Initializes a 128-bit bitvector with effective width determined by the parametric natural type that must not exeed 128
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> init<N,T>(Vector128<T> src, N w = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new BitVector128<N,T>(src);

        /// <summary>
        /// Initializes a 4-bit bitvector with a supplied value
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 init(N4 w, byte src)
            => new BitVector4(src);

        /// <summary>
        /// Initializes an 8-bit bitvector with a supplied value
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 init(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Creates a populated 16-bit bitvector
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 init(ushort src)
            => new BitVector16(src);

        /// <summary>
        /// Initializes a 24-bit bitvector with supplied upper/lower values
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector24 init(ushort lo, byte hi)
            => new BitVector24(lo,hi);

        /// <summary>
        /// Initializes a 24-bit bitvector with a supplied value
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector24 init(N24 w, uint src)
            => new BitVector24(src);

        /// <summary>
        /// Initializes a 16-bit bitvector with a supplied value
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 init(uint src)
            => new BitVector32(src);

        /// <summary>
        /// Initializes a 16-bit bitvector with a supplied value
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 init(ulong src)
            => new BitVector64(src);
    }
}