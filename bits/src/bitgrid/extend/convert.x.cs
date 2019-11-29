//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGridX
    {   

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<M,N,T>(this BitGrid32<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitConvert.GetBytes(src.Data).As<T>();

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<M,N,T>(this BitGrid64<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitConvert.GetBytes(src.Data).As<T>();

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<M,N,T>(this BitGrid128<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.ToSpan();

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<M,N,T>(this BitGrid256<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.ToSpan();

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N8,N8,T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N16,N16,T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N32,N32,T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N64,N64,T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> ToBitMatrix<M,N,T>(this BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMatrix.load<M,N,T>(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> ToBitMatrix<N,T>(this BitGrid<N,N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMatrix.load<N,T>(src.Data);

        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,ushort> ToBitGrid(this BitMatrix16 src)
            => ginx.vload(n256, src.Data);
        
        /// <summary>
        /// Represents the source matrix as a generic bitgrid of dimension 32x32 over cells of width 32
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitGrid<uint> ToBitGrid(this BitMatrix32 src)
            => BitGrid.load(DataBlocks.load(n256,src.Data),32,32);

        [MethodImpl(Inline)]
        public static BitGrid<N64,N64,ulong> ToBitGrid(this BitMatrix64 src, N64 n)
            => BitGrid.load(DataBlocks.load(n256,src.Data),n,n);

        /// <summary>
        /// Represents the source matrix as a generic bitgrid of dimension 64x64 over cells of width 64
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitGrid<ulong> ToBitGrid(this BitMatrix64 src)
            => BitGrid.load(DataBlocks.load(n256,src.Data),64,64);

        /// <summary>
        /// Represents the source value as a 32-bit natural bitgrid of dimension 1x32 
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,uint> ToBitGrid(this uint x, N1 m, N32 n)
            => x;

        /// <summary>
        /// Represents the source value as a 32-bit natural bitgrid of dimension 32x1 
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,uint> ToBitGrid(this uint x, N32 m, N1 n)
            => x;

        /// <summary>
        /// Represents the source value as a 32-bit natural bitgrid of dimension 2x16 
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,uint> ToBitGrid(this uint x, N2 m, N16 n)
            => x;

        /// <summary>
        /// Represents the source value as a 32-bit natural bitgrid of dimension 16x2 
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,uint> ToBitGrid(this uint x, N16 m, N2 n)
            => x;

        /// <summary>
        /// Represents the source value as a 32-bit natural bitgrid of dimension 4x8 
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,uint> ToBitGrid(this uint x, N4 m, N8 n)
            => x;

        /// <summary>
        /// Represents the source value as a 32-bit natural bitgrid of dimension 8x4 
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,uint> ToBitGrid(this uint x, N8 m, N4 n)
            => x;

        /// <summary>
        /// Represents the source value as a 64-bit natural bitgrid of dimension 64x1 
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,ulong> ToBitGrid(this ulong x, N64 m, N1 n)
            => x;

        /// <summary>
        /// Represents the source value as a 64-bit natural bitgrid of dimension 1x64
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,ulong> ToBitGrid(this ulong x, N1 m, N64 n)
            => x;

        /// <summary>
        /// Represents the source value as a 64-bit natural bitgrid of dimension 32x2
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,ulong> ToBitGrid(this ulong x, N32 m, N2 n)
            => x;

        /// <summary>
        /// Represents the source value as a 64-bit natural bitgrid of dimension 2x32
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,ulong> ToBitGrid(this ulong x, N2 m, N32 n)
            => x;

        /// <summary>
        /// Represents the source value as a 64-bit natural bitgrid of dimension 16x4
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> ToBitGrid(this ulong x, N16 m, N4 n)
            => x;

        /// <summary>
        /// Represents the source value as a 64-bit natural bitgrid of dimension 4x16
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> ToBitGrid(this ulong x, N4 m, N16 n)
            => x;

        /// <summary>
        /// Represents the source value as a 64-bit natural bitgrid of dimension 8x8
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,ulong> ToBitGrid(this ulong x, N8 m, N8 n)
            => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 1x128
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> ToBitGrid<T>(this Vector128<T> x, N1 m, N128 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 128x1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> ToBitGrid<T>(this Vector128<T> x, N128 m, N1 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 2x64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> ToBitGrid<T>(this Vector128<T> x, N2 m, N64 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 64x2
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> ToBitGrid<T>(this Vector128<T> x, N64 m, N2 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 4x32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> ToBitGrid<T>(this Vector128<T> x, N4 m, N32 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 32x4
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> ToBitGrid<T>(this Vector128<T> x, N32 m, N4 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 8x16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> ToBitGrid<T>(this Vector128<T> x, N8 m, N16 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 128-bit natural bitgrid of dimension 16x8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> ToBitGrid<T>(this Vector128<T> x, N16 m, N8 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 1x256
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> ToBitGrid<T>(this Vector256<T> x, N1 m, N256 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 256x1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> ToBitGrid<T>(this Vector256<T> x, N256 m, N1 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 2x128
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> ToBitGrid<T>(this Vector256<T> x, N2 m, N128 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 128x2
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> ToBitGrid<T>(this Vector256<T> x, N128 m, N2 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 4x64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> ToBitGrid<T>(this Vector256<T> x, N4 m, N64 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 64x4
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> ToBitGrid<T>(this Vector256<T> x, N64 m, N4 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 8x32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> ToBitGrid<T>(this Vector256<T> x, N8 m, N32 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 32x8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> ToBitGrid<T>(this Vector256<T> x, N32 m, N8 n)
            where T : unmanaged            
                => x;

        /// <summary>
        /// Represents the source vector as a 256-bit natural bitgrid of dimension 16x16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="m">The target row count</param>
        /// <param name="n">The garget col count</param>
        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> ToBitGrid<T>(this Vector256<T> x, N16 m, N16 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid32<T> ToBitGrid<T>(this BitString bs, N32 bitcount, T t = default)
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,t);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N32 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,m,n,t);

        [MethodImpl(Inline)]
        public static BitGrid64<T> ToBitGrid<T>(this BitString bs, N64 bitcount, T t = default)
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,t);

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N64 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,m,n,t);

        [MethodImpl(Inline)]
        public static BitGrid128<T> ToBitGrid<T>(this BitString bs, N128 bitcount, T t = default)
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,t);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N128 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,m,n,t);

        [MethodImpl(Inline)]
        public static BitGrid256<T> ToBitGrid<T>(this BitString bs, N256 bitcount, T t = default)
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,t);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N256 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,bitcount,m,n,t);
                 
    }

}
