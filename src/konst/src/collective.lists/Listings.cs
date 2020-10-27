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
        public static DelimitedList<object> create(params object[] src)
            => new DelimitedList<object>(src, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> create<T>(params T[] src)
            where T : unmanaged
                => new DelimitedList<T>(src, text.delimit, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<object> create(char delimiter, params object[] src)
            => new DelimitedList<object>(src, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> create<T>(char delimiter, params T[] src)
            where T : unmanaged
                => new DelimitedList<T>(src, text.delimit, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnclosedList<T> create<T>(ListEnclosureKind kind, char delimiter, params T[] src)
            where T : unmanaged
                => new EnclosedList<T>(src, kind, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> create<T>(Span<T> src, char delimiter = FieldDelimiter)
            => new DelimitedList<T>(src.ToArray(), delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> create<T>(ReadOnlySpan<T> src, char delimiter = FieldDelimiter)
            => new DelimitedList<T>(src.ToArray(), delimiter);
    }
}