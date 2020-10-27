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

    public static class XListings
    {
        public static DelimitedList<T> Delimit<T>(this ReadOnlySpan<T> src, char delimiter = FieldDelimiter)
            => Listings.create(src, delimiter);

        public static DelimitedList<T> Delimit<T>(this Span<T> src, char delimiter = FieldDelimiter)
            => Listings.create(src, delimiter);

        public static DelimitedList<T> Delimit<T>(this T[] src, char delimiter = FieldDelimiter)
            where T : unmanaged
                => Listings.create(delimiter, src);
    }
}