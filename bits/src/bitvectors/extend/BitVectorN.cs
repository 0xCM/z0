//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this ReadOnlySpan<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitVector.natural(src,n);

        /// <summary>
        /// Converts the least significant elements of a generic natural bitvector to a 8-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector8 ToPrimal<N,T>(this BitVector<N,T> src, N8 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt8();

        /// <summary>
        /// Converts the least significant elements of a generic natural bitvector to a 16-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector16 ToPrimal<N,T>(this BitVector<N,T> src, N16 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt16();

        /// <summary>
        /// Converts the least significant elements of generic natural bitvector to a 32-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector32 ToPrimal<N,T>(this BitVector<N,T> src, N32 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt32();

        /// <summary>
        /// Converts the leading elements of generic bitvector to a 64-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector64 ToPrimal<N,T>(this BitVector<N,T> src, N64 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt64();

        [MethodImpl(Inline)]
        public static BitCells<T> ToCells<N,T>(this BitVector<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitCells.load(src.Data, natval<N>());

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> ToBitVector<N,T>(this Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitVector.natural(src,n);

 
    }

}