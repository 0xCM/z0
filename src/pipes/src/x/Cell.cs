//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XSource
    {
        [MethodImpl(Inline), Op]
        public static Cell8 Cell(this ISource src, W8 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell16 Cell(this ISource src, W16 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell32 Cell(this ISource src, W32 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell64 Cell(this ISource src, W64 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell128 Cell(this ISource src, W128 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell256 Cell(this ISource src, W256 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell512 Cell(this ISource src, W512 w)
            => Sources.cell(src, w);
    }
}