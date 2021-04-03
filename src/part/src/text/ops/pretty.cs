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
        public static string assign(object lhs, object rhs)
            => TextFormat.concat(lhs, Space, Assignment, Space, rhs);

        /// <summary>
        /// Encloses content between '(' and ')' characters
        /// </summary>
        /// <param name="content">The items to be enclosed</param>
        [Op]
        public static string parenthetical(params object[] content)
            => TextFormat.enclose(string.Concat(content.Select(x => x.ToString())), Chars.LParen, Chars.RParen);

        [MethodImpl(Inline)]
        public static string rpad(string src, int width, char c = Space)
            => Format.rpad(src, width, c);
    }
}