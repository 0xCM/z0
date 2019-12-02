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
        /// <param name="n">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> parse<T>(BitString bs, N32 n, T t = default)
            where T : unmanaged
                => bs.TakeUInt32();

        /// <summary>
        /// Hydrates a fixed-width 64-bit dimensionless grid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="n">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> parse<T>(BitString bs, N64 n, T t = default)
            where T : unmanaged
                => bs.TakeUInt64();

        /// <summary>
        /// Hydrates a fixed-width 128-bit dimensionless grid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="n">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<T> parse<T>(BitString bs, N128 n, T t = default)
            where T : unmanaged
                => dinx.vload(n, head(bs.Pack(0,n)));

        /// <summary>
        /// Hydrates a fixed-width 128-bit dimensionless grid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="n">The number of bitstring bits to parse</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<T> parse<T>(BitString bs, N256 n, T t = default)
            where T : unmanaged
                => dinx.vload(n, head(bs.Pack(0,n)));
    }

}