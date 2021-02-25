//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;
    using static TextRules;


    partial class XText
    {
        [TextUtility]
        public static string Between(this string src, char left, char right)
            => Parse.between(src, left, right);

        public static DelimitedIndex<T> Delimit<T>(this T[] src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(src, delimiter);

        public static DelimitedIndex<T> Delimit<T>(this IEnumerable<T> src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(src.Array(), delimiter);
    }
}