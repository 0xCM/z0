//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Performs a string comparison according to a specified comparison type
            /// </summary>
            /// <param name="a">The first string</param>
            /// <param name="b">The second string</param>
            /// <param name="type">The comparison type</param>
            [MethodImpl(Inline), Op]
            public static bool equals(string a, string b, StringComparison type)
                => string.Equals(a,b, type);

            /// <summary>
            /// Performs a case-insensitive comparison on two source strings
            /// </summary>
            /// <param name="a">The first string</param>
            /// <param name="b">The second string</param>
            [MethodImpl(Inline), Op]
            public static bool equals(string a, string b)
                => string.Equals(a,b, NoCase);
        }
    }
}