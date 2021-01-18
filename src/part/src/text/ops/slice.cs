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

    partial struct text
    {
        [MethodImpl(Inline)]
        public static string slice(string src, int offset)
            => Parse.slice(src, offset);

        [MethodImpl(Inline)]
        public static string slice(string src, int offset, int length)
            => Parse.slice(src, offset, length);

        [MethodImpl(Inline)]
        public static string slice(string src, uint offset)
            => Parse.slice(src, offset);

        [MethodImpl(Inline)]
        public static string slice(string src, uint offset, uint length)
            => Parse.slice(src, offset, length);
    }
}