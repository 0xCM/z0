//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XCell
    {
        [MethodImpl(Inline), Op]
        public static Cell8 Cell(this IDataSource src, W8 w)
            => CellSource.next(src, w);

        [MethodImpl(Inline), Op]
        public static Cell16 Cell(this IDataSource src, W16 w)
            => CellSource.next(src, w);

        [MethodImpl(Inline), Op]
        public static Cell32 Cell(this IDataSource src, W32 w)
            => CellSource.next(src, w);

        [MethodImpl(Inline), Op]
        public static Cell64 Cell(this IDataSource src, W64 w)
            => CellSource.next(src, w);

        [MethodImpl(Inline), Op]
        public static Cell128 Cell(this IDataSource src, W128 w)
            => CellSource.next(src, w);

        [MethodImpl(Inline), Op]
        public static Cell256 Cell(this IDataSource src, W256 w)
            => CellSource.next(src, w);

        [MethodImpl(Inline), Op]
        public static Cell512 Cell(this IDataSource src, W512 w)
            => CellSource.next(src, w);
    }
}