//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        [MethodImpl(Inline), Op]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);

        [MethodImpl(Inline), Op]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// If the test string is null, returns the empty string; otherwise, returns the test string
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline), Op]
        public static string denullify(string test)
            => empty(test) ? string.Empty : test;
    }
}