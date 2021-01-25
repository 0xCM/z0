//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct TextRules
    {
        partial struct Format
        {
            [MethodImpl(Inline), Op]
            public static string adjacent(dynamic a, dynamic b)
                => string.Format(RP.Adjacent2, a, b);

            [MethodImpl(Inline), Op]
            public static string adjacent(dynamic a, dynamic b, dynamic c)
                => string.Format(RP.Adjacent3, a, b, c);

            [MethodImpl(Inline), Op]
            public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d)
                => string.Format(RP.Adjacent4, a, b, c, d);

            [MethodImpl(Inline), Op]
            public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e)
                => string.Format(RP.Adjacent5, a, b, c, d, e);

            [MethodImpl(Inline), Op]
            public static string adjacent(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e, dynamic f)
                => string.Format(RP.Adjacent6, a, b, c, d, e, f);
        }
    }
}