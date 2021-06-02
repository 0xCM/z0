//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static Cell16 join(byte lo, byte hi)
            => (lo, hi);

        [MethodImpl(Inline), Op]
        public static Cell32 join(ushort lo, ushort hi)
            => (lo, hi);

        [MethodImpl(Inline), Op]
        public static Cell64 join(uint lo, uint hi)
            => (lo, hi);

        [MethodImpl(Inline), Op]
        public static Cell128 join(ulong lo, ulong hi)
            => (lo, hi);

        [MethodImpl(Inline), Op]
        public static Cell256 join(Cell128 lo, Cell128 hi)
            => (lo, hi);

        [MethodImpl(Inline), Op]
        public static Cell512 join(Cell256 lo, Cell256 hi)
            => (lo, hi);
    }
}