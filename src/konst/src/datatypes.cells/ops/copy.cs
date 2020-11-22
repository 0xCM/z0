//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        static void copy(W8 w, in byte src, ref byte dst)
            => dst = src;

        [MethodImpl(Inline), Op]
        static void copy(W16 w, in byte src, ref byte dst)
            => u16(dst) = u16(src);

        [MethodImpl(Inline), Op]
        static void copy(W32 w, in byte src, ref byte dst)
            => u32(dst) = u32(src);

        [MethodImpl(Inline), Op]
        static void copy(W64 w, in byte src, ref byte dst)
            => u64(dst) = u64(src);
    }
}