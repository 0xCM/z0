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

    partial class text
    {
        /// <summary>
        /// Inserts a string into the intern pool if it is not already there and, in any case, returns the string's address
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress intern(string src)
            => address(string.Intern(src));


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