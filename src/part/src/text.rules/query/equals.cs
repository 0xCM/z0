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
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            [MethodImpl(Inline), Op]
            public static bool equals(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
                => lhs.CompareTo(rhs, InvariantCulture) == 0;

            /// <summary>
            /// Returns true if the character spans are equal as strings, false otherwise
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            [MethodImpl(Inline), Op]
            public static bool equals(Span<char> lhs, ReadOnlySpan<char> rhs)
                => equals(lhs.ReadOnly(), rhs);

            /// <summary>
            /// Returns true if the character spans are equal as strings, false otherwise
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            [MethodImpl(Inline), Op]
            public static bool equals(Span<char> lhs, Span<char> rhs)
                => equals(lhs.ReadOnly(), rhs.ReadOnly());
        }
    }
}