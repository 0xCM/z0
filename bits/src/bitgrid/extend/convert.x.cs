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
                => BitConvert.GetBytes(src.Scalar).As<T>();

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<M,N,T>(this BitGrid64<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitConvert.GetBytes(src.Scalar).As<T>();

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
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N8, N8, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N16, N16, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N32, N32, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this BitGrid<N64, N64, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> ToBitMatrix<M,N,T>(this BitGrid<M, N, T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMatrix.load<M,N,T>(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> ToBitMatrix<N,T>(this BitGrid<N, N, T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMatrix.load<N,T>(src.Data);

        [MethodImpl(Inline)]
        public static BitGrid<N8,N8, T> ToGrid<T>(this BitMatrix<T> src, N8 m)
            where T : unmanaged
                => BitGrid.load(src.Data,m,m);

        [MethodImpl(Inline)]
        public static BitGrid<N16,N16, T> ToGrid<T>(this BitMatrix<T> src, N16 n)
            where T : unmanaged
                => BitGrid.load(src.Data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<N32,N32, T> ToGrid<T>(this BitMatrix<T> src, N32 n)
            where T : unmanaged
                => BitGrid.load(src.Data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<N64,N64, T> ToGrid<T>(this BitMatrix<T> src, N64 n)
            where T : unmanaged
                => BitGrid.load(src.Data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<N8,N8, byte> ToGrid(this BitMatrix8 src, N8 n)
            => BitGrid.load(src.data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<byte> ToGrid(this BitMatrix8 src)
            => BitGrid.load(src.data, 8,8);

        [MethodImpl(Inline)]
        public static BitGrid<N16,N16, ushort> ToGrid(this BitMatrix16 src, N16 n)
            => BitGrid.load(src.Data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<ushort> ToGrid(this BitMatrix16 src)
            => BitGrid.load(src.Data, 16,16);

        [MethodImpl(Inline)]
        public static BitGrid<N32,N32, uint> ToGrid(this BitMatrix32 src, N32 n)
            => BitGrid.load(src.Data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<uint> ToGrid(this BitMatrix32 src)
            => BitGrid.load(src.Data, 32,32);

        [MethodImpl(Inline)]
        public static BitGrid<N64,N64,ulong> ToGrid(this BitMatrix64 src, N64 n)
            => BitGrid.load(src.Data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<ulong> ToGrid(this BitMatrix64 src)
            => BitGrid.load(src.Data, 64,64);

        [MethodImpl(Inline)]
        public static BitGrid32<N1,N32,uint> ToBitGrid(this uint x, N1 m, N32 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid32<N32,N1,uint> ToBitGrid(this uint x, N32 m, N1 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid32<N2,N16,uint> ToBitGrid(this uint x, N2 m, N16 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid32<N16,N2,uint> ToBitGrid(this uint x, N16 m, N2 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid32<N4,N8,uint> ToBitGrid(this uint x, N4 m, N8 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid32<N8,N4,uint> ToBitGrid(this uint x, N8 m, N4 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid64<N64,N1,ulong> ToBitGrid(this ulong x, N64 m, N1 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid64<N1,N64,ulong> ToBitGrid(this ulong x, N1 m, N64 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid64<N32,N2,ulong> ToBitGrid(this ulong x, N32 m, N2 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid64<N2,N32,ulong> ToBitGrid(this ulong x, N2 m, N32 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> ToBitGrid(this ulong x, N16 m, N4 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid64<N4,N16,ulong> ToBitGrid(this ulong x, N4 m, N16 n)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,ulong> ToBitGrid(this ulong x, N8 m, N8 n = default)
            => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N1,N128,T> ToBitGrid<T>(this Vector128<T> x, N1 m, N128 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N128,N1,T> ToBitGrid<T>(this Vector128<T> x, N128 m, N1 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,T> ToBitGrid<T>(this Vector128<T> x, N2 m, N64 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N64,N2,T> ToBitGrid<T>(this Vector128<T> x, N64 m, N2 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,T> ToBitGrid<T>(this Vector128<T> x, N4 m, N32 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N32,N4,T> ToBitGrid<T>(this Vector128<T> x, N32 m, N4 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,T> ToBitGrid<T>(this Vector128<T> x, N8 m, N16 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,T> ToBitGrid<T>(this Vector128<T> x, N16 m, N8 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N1,N256,T> ToBitGrid<T>(this Vector256<T> x, N1 m, N256 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N256,N1,T> ToBitGrid<T>(this Vector256<T> x, N256 m, N1 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> ToBitGrid<T>(this Vector256<T> x, N2 m, N128 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N128,N2,T> ToBitGrid<T>(this Vector256<T> x, N128 m, N2 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N4,N64,T> ToBitGrid<T>(this Vector256<T> x, N4 m, N64 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N64,N4,T> ToBitGrid<T>(this Vector256<T> x, N64 m, N4 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N8,N32,T> ToBitGrid<T>(this Vector256<T> x, N8 m, N32 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N32,N8,T> ToBitGrid<T>(this Vector256<T> x, N32 m, N8 n)
            where T : unmanaged            
                => x;

        [MethodImpl(Inline)]
        public static BitGrid256<N16,N16,T> ToBitGrid<T>(this Vector256<T> x, N16 m, N16 n = default)
            where T : unmanaged            
                => x;
    }

}
