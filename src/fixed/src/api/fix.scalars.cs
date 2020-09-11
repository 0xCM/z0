//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static Cell8 fix(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell8 fix(sbyte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell16 fix(short src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell16 fix(ushort src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell32 fix(int src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell32 fix(uint src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell64 fix(long src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell64 fix(ulong src)
            => src;
    }
}