//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static Cell128 cell128((ulong x0, ulong x1) x)
            => new Cell128(x.x0, x.x1);

        [MethodImpl(Inline), Op]
        public static Cell128 cell128(in ConstPair<ulong> x)
            => new Cell128(x.Left, x.Right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Cell128 cell128<T>(Vector128<T> src)
            where T : unmanaged
                => new Cell128(gcpu.v64u(src));

        /// <summary>
        /// Seeks an index-identified <see cref='Cell128'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell128 cell128(in Cell256 src, uint1 part)
            => ref seek(@as<Cell256,Cell128>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell128'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell128 cell128(in Cell512 src, uint2 part)
            => ref seek(@as<Cell512,Cell128>(src), part);
    }
}