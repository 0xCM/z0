//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    partial class text
    {
        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b)
            => Format.adjacent(a, b);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c)
            => Format.adjacent(a, b, c);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d)
            => Format.adjacent(a, b, c, d);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e)
            => Format.adjacent(a, b, c, d, e);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e, dynamic f)
            => Format.adjacent(a, b, c, d, e, f);
    }
}