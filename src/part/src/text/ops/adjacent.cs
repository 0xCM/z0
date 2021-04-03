//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class text
    {
        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b)
            => TextFormat.adjacent(a, b);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c)
            => TextFormat.adjacent(a, b, c);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d)
            => TextFormat.adjacent(a, b, c, d);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e)
            => TextFormat.adjacent(a, b, c, d, e);

        [MethodImpl(Inline)]
        public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e, dynamic f)
            => TextFormat.adjacent(a, b, c, d, e, f);
    }
}