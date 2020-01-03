//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class BitBlockX
    {
        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> ToBitBlock<N,T>(this ReadOnlySpan<T> src, N n = default)
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
        public static BitBlock<N,T> ToBitBlock<N,T>(this Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitBlocks.load(src,n);

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

        /// <summary>
        /// Constructs a 16-bit bitvector from a sequence of bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector<T>(this BitBlock<T> src, N16 n)
            where T : unmanaged
                => src.Data.TakeUInt16();

        /// <summary>
        /// Constructs a 32-bit bitvector from a sequence of bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector<T>(this BitBlock<T> src, N32 n)
            where T : unmanaged
                => src.Data.TakeUInt32();

        /// <summary>
        /// Constructs a 64-bit bitvector from a sequence of bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector<T>(this BitBlock<T> src, N64 n)
            where T : unmanaged
                => src.Data.TakeUInt64();
 
        /// <summary>
        /// Converts the source bitvector to bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitBlock<N8,byte> ToBitCells(this BitVector8 src)
            => new BitBlock<N8, byte>(src);

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitBlock<N16,ushort> ToBitCells(this BitVector16 src)
            => new BitBlock<N16, ushort>(src);

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitBlock<N64,ulong> ToBitCells(this BitVector64 src)
            => new BitBlock<N64, ulong>(src);

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
        /// Extracts the bitcells from a source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<T> ToBitCells<T>(this BitVector<T> src)
            where T : unmanaged
                => BitBlocks.literals(src.Scalar);

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
        public static BitVector128<N,T> from<N,T>(BitString src, N128 n = default, T zero = default)
            where T : unmanaged   
            where N : unmanaged, ITypeNat
                => DataBlocks.safeload(n,src.Pack().As<byte, T>()).LoadVector();

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline)]
        public static BitVector128<N128,ulong> Expand(this BitVector64 src, N128 n)
            => new BitVector128<N128, ulong>(dinx.vscalar(n,src));


    }
}