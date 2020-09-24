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
        public static string format(Cell8 src)
            => src.Content.FormatHexData();

        [MethodImpl(Inline), Op]
        public static string format(Cell16 src)
            => src.Content.FormatHexData();

        [MethodImpl(Inline), Op]
        public static string format(Cell32 src)
            => src.Content.FormatHexData();

        [MethodImpl(Inline), Op]
        public static string format(Cell64 src)
            => src.Content.FormatHexData();
    }
}