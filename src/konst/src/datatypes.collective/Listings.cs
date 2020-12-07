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

    [ApiHost(ApiNames.Listings, true)]
    public readonly struct Listings
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<object> create(params object[] src)
            => new DelimitedIndex<object>(src, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> create<T>(params T[] src)
            where T : unmanaged
                => new DelimitedIndex<T>(src, text.delimit, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<object> create(char delimiter, params object[] src)
            => new DelimitedIndex<object>(src, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> create<T>(char delimiter, params T[] src)
            where T : unmanaged
                => new DelimitedIndex<T>(src, text.delimit, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnclosedList<T> create<T>(ListEnclosureKind kind, char delimiter, params T[] src)
            where T : unmanaged
                => new EnclosedList<T>(src, kind, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> create<T>(Span<T> src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(src.ToArray(), delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> create<T>(ReadOnlySpan<T> src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(src.ToArray(), delimiter);
    }
}