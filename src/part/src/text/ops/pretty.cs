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
        public static string squote(object src)
            => Format.enclose(src, CharText.SQuote);

        [MethodImpl(Inline)]
        public static string assign(object lhs, object rhs)
            => Format.concat(lhs, Space, Assignment, Space, rhs);

        [MethodImpl(Inline)]
        public static string parenthetical(params object[] content)
            => Format.parenthetical(content);

        [MethodImpl(Inline)]
        public static string rpad(string src, int width, char c = Space)
            => Format.rpad(src, width, c);

        [MethodImpl(Inline)]
        public static string label(object name, object content)
            => Format.label(name, content);
    }
}