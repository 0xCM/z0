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

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static byte scalar(Cell8 src)
            =>  (byte)src;

        [MethodImpl(Inline), Op]
        public static ushort scalar(Cell16 src)
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static uint scalar(Cell32 src)
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static ulong scalar(Cell64 src)
            => (ulong)src;
    }
}