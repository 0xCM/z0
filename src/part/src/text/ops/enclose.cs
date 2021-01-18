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
        public static string enclose(object content, string left, string right)
            => Format.enclose(content, left, right);

        [MethodImpl(Inline)]
        public static string enclose(object content, string sep)
            => Format.enclose(content, sep);

        [MethodImpl(Inline)]
        public static string enclose(char content, string sep)
            => Format.enclose(content, sep);

        [MethodImpl(Inline)]
        public static string enclose(char content, string left, string right)
            => Format.enclose(content, left, right);

        [MethodImpl(Inline)]
        public static string enclose(object content, char left, char right)
            => Format.enclose(content, left, right);
    }
}