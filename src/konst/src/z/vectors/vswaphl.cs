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

    partial struct z
    {                         
        /// <summary>
        /// Swaps the source vectors' hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vswaphl(Vector256<byte> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vswaphl(Vector256<sbyte> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vswaphl(Vector256<short> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vswaphl(Vector256<ushort> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vswaphl(Vector256<int> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vswaphl(Vector256<uint> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vswaphl(Vector256<long> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vswaphl(Vector256<ulong> x)
            => vperm2x128(x,x, Perm2x4.DA);

    }
}