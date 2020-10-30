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

    partial class XCell
    {
        [MethodImpl(Inline), Op]
        public static Cell8 ToCell(this byte x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell8 ToCell(this sbyte x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell16 ToCell(this short x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell16 ToCell(this ushort x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell32 ToCell(this int x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell32 ToCell(this uint x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell64 ToCell(this long x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell64 ToCell(this ulong x)
            => x;
    }
}