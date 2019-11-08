//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    public static class BitGridX
    {   
        [MethodImpl(Inline)]
        public static BitMatrix<T> ToMatrix<T>(this BitGrid<N8, N8, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToMatrix<T>(this BitGrid<N16, N16, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToMatrix<T>(this BitGrid<N32, N32, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<T> ToMatrix<T>(this BitGrid<N64, N64, T> src)
            where T : unmanaged
                => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> ToMatrix<M,N,T>(this BitGrid<M, N, T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMatrix.load<M,N,T>(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> ToMatrix<N,T>(this BitGrid<N, N, T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMatrix.load<N,T>(src.Data);

        [MethodImpl(Inline)]
        public static BitGrid<N8,N8, T> ToGrid<T>(this BitMatrix<T> src, N8 n)
            where T : unmanaged
                => BitGrid.load(src.Data,n,n);

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
            => BitGrid.load(src.Data,n,n);

        [MethodImpl(Inline)]
        public static BitGrid<byte> ToGrid(this BitMatrix8 src)
            => BitGrid.load(src.Data, 8,8);

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
        public static BitString ToBitString<M,N,T>(this BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.ToBitString(BitGrid.points(src.Moniker));

        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid<T> src)
            where T : unmanaged
                => src.Data.ToBitString(BitGrid.points(src.Moniker));

        [MethodImpl(NotInline)]
        public static BitGrid<T> Replicate<T>(this BitGrid<T> src)
            where T : unmanaged
                => new BitGrid<T>(src.Data.Replicate(), src.Moniker);

        public static string Format(this GridMap map, int? colpad = null, char? delimiter = null)
            => BitGrid.format(map, colpad, delimiter);

        public static string Format(this GridStats stats, int? colpad = null, char? delimiter = null)
            => BitGrid.format(stats, colpad, delimiter);

        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        /// <typeparam name="T">The storage type</typeparam>
        public static GridMap Map(this GridSpec spec)
            => BitGrid.map(spec);

        public static GridStats Stats(this GridMap map)
            => BitGrid.stats(map);

        public static GridStats Stats(this GridSpec spec)
            => BitGrid.stats(BitGrid.map(spec));


    }

}