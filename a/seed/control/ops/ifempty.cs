//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        /// <summary>
        /// A string-specific coalescing operation
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string ifempty(string test, string replace)
            => string.IsNullOrWhiteSpace(test) ? replace ?? string.Empty : test;
    }
}