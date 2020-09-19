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
        public static Cell8 cell(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell8 cell(sbyte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell16 cell(short src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell16 cell(ushort src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell32 cell(int src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell32 cell(uint src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell64 cell(long src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell64 cell(ulong src)
            => src;
    }
}