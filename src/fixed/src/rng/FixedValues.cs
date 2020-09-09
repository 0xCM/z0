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
        public static Cell8 Fixed(this IValueSource source, W8 w)
            => FixedValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell16 Fixed(this IValueSource source, W16 w)
            => FixedValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell32 Fixed(this IValueSource source, W32 w)
            => FixedValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell64 Fixed(this IValueSource source, W64 w)
            => FixedValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell128 Fixed(this IValueSource source, W128 w)
            => FixedValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell256 Fixed(this IValueSource source, W256 w)
            => FixedValues.next(source, w);

        [MethodImpl(Inline)]
        public static Cell512 Fixed(this IValueSource source, W512 w)
            => FixedValues.next(source, w);
    }
}