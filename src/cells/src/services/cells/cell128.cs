//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static Cell128 cell128((ulong x0, ulong x1) x)
            => new Cell128(x.x0, x.x1);

        [MethodImpl(Inline), Op]
        public static Cell128 cell128(ulong lo, ulong hi)
            => new Cell128(lo, hi);

        [MethodImpl(Inline), Op]
        public static Cell128 cell128(uint a00, uint a01, uint a10, uint a11)
            => new Cell128(a00,a01,a10,a11);

        // [MethodImpl(Inline), Op]
        // public static Cell128 cell128(in ConstPair<ulong> x)
        //     => new Cell128(x.Left, x.Right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Cell128 cell128<T>(Vector128<T> src)
            where T : unmanaged
                => new Cell128(src.AsUInt64());
    }
}