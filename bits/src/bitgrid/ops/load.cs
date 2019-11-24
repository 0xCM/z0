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

    partial class BitGrid
    {
        /// <summary>
        /// Loads a generic bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="map">The grid map</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> load<T>(Span<T> src, ushort rows, ushort cols)
            where T : unmanaged
                => new BitGrid<T>(src, rows, cols);

        /// <summary>
        /// Loads a natural bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="zero">The storage representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var layout = GridMap.Define(m,n,zero);
            require(src.Length == layout.SegCount);
            return new BitGrid<M, N, T>(src);
        }

        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> load<M,N,T>(M m, N n, params T[] data)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
        {
            var natbits = NatMath.mul(m,n) ;   
            var databits = data.Length * bitsize<T>();
            if(databits < natbits)
                Errors.ThrowInvariantFailure($"{databits} < {natbits}");

            return new BitGrid<M,N,T>(data);
        }

        /// <summary>
        /// Loads a natural bitgrid of dimensions Mx8 of type byte from primal bitvectors of length 8
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N8,byte> load<M>(M m, Span<BitVector8> src)
            where M : unmanaged, ITypeNat
                => load<M,N8,byte>(src.AsBytes());

        /// <summary>
        /// Loads a natural bitgrid of dimensions Mx16 of type ushort from primal bitvectors of length 16
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N16,ushort> load<M>(M m, Span<BitVector16> src)
            where M : unmanaged, ITypeNat
                => load<M,N16,ushort>(src.AsUInt16());

        /// <summary>
        /// Loads a natural bitgrid of dimensions Mx32 of type uint from primal bitvectors of length 32
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N32,uint> load<M>(M m, Span<BitVector32> src)
            where M : unmanaged, ITypeNat
                => load<M,N32,uint>(src.AsUInt32());

        /// <summary>
        /// Loads a natural bitmatrix of dimensions Mx64 of type ulong from primal bitvectors of length 64
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N64,ulong> load<M>(M m, Span<BitVector64> src)
            where M : unmanaged, ITypeNat
                => load<M,N64,ulong>(src.AsUInt64());
 
        /// <summary>
        /// Forms a 1x64 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> loadlo<T>(Vector128<T> src, N1 m = default, N64 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(0);

        /// <summary>
        /// Forms a 64x1 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> loadlo<T>(Vector128<T> src, N64 m = default, N1 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(0);

        /// <summary>
        /// Forms a 2x32 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> loadlo<T>(Vector128<T> src, N2 m = default, N32 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(0);

        /// <summary>
        /// Forms a 32x2 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> loadlo<T>(Vector128<T> src, N32 m = default, N2 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(0);

        /// <summary>
        /// Forms a 4x16 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> loadlo<T>(Vector128<T> src, N4 m = default, N16 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(0);

        /// <summary>
        /// Forms a 16x4 from the lower 64 bits of a vector
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> loadlo<T>(Vector128<T> src, N16 m = default, N4 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(0);

        /// <summary>
        /// Forms a 8x8 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> loadlo<T>(Vector128<T> src, N8 m = default, N8 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(0);

        /// <summary>
        /// Forms a 1x64 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,T> loadhi<T>(Vector128<T> src, N1 m = default, N64 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(1);

        /// <summary>
        /// Forms a 64x1 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,T> loadhi<T>(Vector128<T> src, N64 m = default, N1 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(1);

        /// <summary>
        /// Forms a 2x32 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,T> loadhi<T>(Vector128<T> src, N2 m = default, N32 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(1);

        /// <summary>
        /// Forms a 32x2 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,T> loadhi<T>(Vector128<T> src, N32 m = default, N2 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(1);

        /// <summary>
        /// Forms a 4x16 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,T> loadhi<T>(Vector128<T> src, N4 m = default, N16 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(1);

        /// <summary>
        /// Forms a 16x4 from the lower 64 bits of a vector
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,T> loadhi<T>(Vector128<T> src, N16 m = default, N4 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(1);

        /// <summary>
        /// Forms a 8x8 grid from the lower 64 bits of a vector
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> loadhi<T>(Vector128<T> src, N8 m = default, N8 n = default)
            where T : unmanaged            
                => src.AsUInt64().GetElement(1);

        /// <summary>
        /// Forms a 1x128 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> load<T>(Vector128<T> src, N1 m = default, N128 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 128x1 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> load<T>(Vector128<T> src,  N128 m = default, N1 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 2x64 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> load<T>(Vector128<T> src, N2 m = default, N64 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 64x2 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> load<T>(Vector128<T> src, N64 m = default, N2 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 4x32 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> load<T>(Vector128<T> src, N4 m = default, N32 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 32x4 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> load<T>(Vector128<T> src, N32 m = default, N4 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 8x16 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> load<T>(Vector128<T> src, N8 m = default, N16 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 16x8 grid from a 128-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> load<T>(Vector128<T> src, N16 m = default, N8 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 1x256 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> load<T>(Vector256<T> src, N1 m = default, N256 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 256x1 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> load<T>(Vector256<T> src, N256 m = default, N1 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 2x128 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N2,N128,T> load<T>(Vector256<T> src, N2 m = default, N128 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 128x2 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> load<T>(Vector256<T> src, N128 m = default, N2 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 4x64 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> load<T>(Vector256<T> src, N4 m = default, N64 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 64x4 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> load<T>(Vector256<T> src, N64 m = default, N4 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 8x32 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> load<T>(Vector256<T> src, N8 m = default, N32 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 32x8 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> load<T>(Vector256<T> src, N32 m = default, N8 n = default)
            where T : unmanaged            
                => src;

        /// <summary>
        /// Forms a 16x16 grid from a 256-bit vector
        /// </summary>
        /// <param name="block">The block size selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="fill">The value with which to fill the grid</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> load<T>(Vector256<T> src, N16 m = default, N16 n = default)
            where T : unmanaged            
                => src; 
    }

}