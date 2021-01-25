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

            /// <summary>
            /// Returns true if the character spans are equal as strings, false otherwise
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Op]
            public static bool equals(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
                => a.CompareTo(b, InvariantCulture) == 0;

            /// <summary>
            /// Returns true if the character spans are equal as strings, false otherwise
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Op]
            public static bool equals(Span<char> a, ReadOnlySpan<char> b)
                => equals(a.ReadOnly(), b);

            /// <summary>
            /// Returns true if the character spans are equal as strings, false otherwise
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Op]
            public static bool equals(Span<char> a, Span<char> b)
                => equals(a.ReadOnly(), b.ReadOnly());
        }
    }
}