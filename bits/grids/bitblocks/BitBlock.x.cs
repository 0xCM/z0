//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;
    using static Nats;

    public static class BitBlockX
    {
        /// <summary>
        /// Converts the source bitvector to bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitBlock<N8,byte> ToNatBits(this BitVector8 src)
            => new BitBlock<N8, byte>(src);

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitBlock<N16,ushort> ToNatBits(this BitVector16 src)
            => new BitBlock<N16, ushort>(src);

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitBlock<N64,ulong> ToNatBits(this BitVector64 src)
            => new BitBlock<N64, ulong>(src);

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> ToNatBits<N,T>(this ReadOnlySpan<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitBlocks.load(src,n);

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> ToNatBits<N,T>(this Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitBlocks.load(src,n);

        /// <summary>
        /// Extracts the bitcells froma span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<T> ToBitCells<T>(this Span<T> src, int len)
            where T : unmanaged
                => BitBlocks.load(src,len);

        /// <summary>
        /// Converts the least significant elements of a generic natural bitvector to a 8-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector<N,T>(this BitBlock<N,T> src, N8 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt8();

        /// <summary>
        /// Converts the least significant elements of a generic natural bitvector to a 16-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector<N,T>(this BitBlock<N,T> src, N16 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt16();

        [MethodImpl(Inline)]
        public static BitBlock<T> Unsize<N,T>(this BitBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitBlocks.load(src.Data, natval<N>()); 

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitString.scalars(src.Data, src.Width); 

        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitBlock<N,T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public static BitBlock<N,T> ToBitCells<N,T>(this BitVector128<N,T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitBlocks.load(src.Data.ToSpan(),n);

        /// <summary>
        /// Extracts a 128-bit cpu vector from a bitsring of sufficient length
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="w">The bit width selector</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The target vectror component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> ToCpuVector<T>(this BitString src, N128 w, T t = default)
            where T : unmanaged   
                => src.Pack().As<byte, T>().Blocked(w).LoadVector();

        /// <summary>
        /// Extracts a 256-bit cpu vector from a bitsring of sufficient length
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="w">The bit width selector</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The target vectror component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> ToCpuVector<T>(this BitString src, N256 w, T t = default)
            where T : unmanaged
                => src.Pack().As<byte, T>().Blocked(w).LoadVector();

        [MethodImpl(Inline)]
        public static bit Identical<T>(this Block128<T> xb, Block128<T> yb)        
            where T : unmanaged        
                => xb.Data.Identical(yb.Data);

        [MethodImpl(Inline)]
        public static bit Identical<T>(this Block256<T> xb, Block256<T> yb)        
            where T : unmanaged        
                => xb.Data.Identical(yb.Data);
    }
}