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
        /// Hydrates a fixed-width 32-bit dimensionless grid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> parse<T>(BitString bs, N32 bitcount, T t = default)
            where T : unmanaged
                => bs.TakeUInt32();

        /// <summary>
        /// Hydrates a 32-bit natural bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> parse<M,N,T>(BitString bs, N32 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => parse(bs, bitcount, t);

        /// <summary>
        /// Hydrates a fixed-width 64-bit dimensionless grid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> parse<T>(BitString bs, N64 bitcount, T t = default)
            where T : unmanaged
                => bs.TakeUInt64();

        /// <summary>
        /// Hydrates a 64-bit natural bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> parse<M,N,T>(BitString bs, N64 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => parse(bs, bitcount, t);

        /// <summary>
        /// Hydrates a fixed-width 128-bit dimensionless grid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<T> parse<T>(BitString bs, N128 bitcount, T t = default)
            where T : unmanaged
                => dinx.vload(bitcount, head(bs.Pack(0,bitcount)));

        /// <summary>
        /// Hydrates a 128-bit natural bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> parse<M,N,T>(BitString bs, N128 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => parse(bs,bitcount,t);

        /// <summary>
        /// Hydrates a fixed-width 128-bit dimensionless grid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<T> parse<T>(BitString bs, N256 bitcount, T t = default)
            where T : unmanaged
                => dinx.vload(bitcount, head(bs.Pack(0,bitcount)));

        /// <summary>
        /// Hydrates a 256-bit natural bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="bitcount">The number of bitstring bits to parse</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> parse<M,N,T>(BitString bs, N256 bitcount, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => parse(bs,bitcount,t);
    }
}