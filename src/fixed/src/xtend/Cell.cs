//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XRng
    {
        [MethodImpl(Inline)]
        public static Cell8 Cell(this IValueSource source, W8 w)
            => CellValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell16 Cell(this IValueSource source, W16 w)
            => CellValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell32 Cell(this IValueSource source, W32 w)
            => CellValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell64 Cell(this IValueSource source, W64 w)
            => CellValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell128 Cell(this IValueSource source, W128 w)
            => CellValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell256 Cell(this IValueSource source, W256 w)
            => CellValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell512 Cell(this IValueSource source, W512 w)
            => CellValues.next(source, w);
    }
}