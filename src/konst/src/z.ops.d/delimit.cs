//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static DelimitedList<object> delimit(params object[] src)
            => Listings.create(src);

        [MethodImpl(Inline)]
        public static DelimitedList<T> delimit<T>(params T[] src)
            where T : unmanaged
                => Listings.create(src);

        [MethodImpl(Inline)]
        public static DelimitedList<object> delimit(char delimiter, params object[] src)
                => Listings.create(delimiter, src);

        [MethodImpl(Inline)]
        public static DelimitedList<T> delimit<T>(char delimiter, params T[] src)
            where T : unmanaged
                => Listings.create(delimiter, src);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(params T[] src)
            where T : unmanaged
                => Listings.create(ListEnclosureKind.Embraced, Chars.Comma, src);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(ListEnclosureKind kind, params T[] src)
            where T : unmanaged
                => Listings.create(kind, Chars.Comma, src);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(ListEnclosureKind kind, char delimiter, params T[] src)
            where T : unmanaged
                => Listings.create(kind, delimiter, src);
    }
}