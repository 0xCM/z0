//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class text
    {
        /// <summary>
        /// Encloses text between single quote (') characters
        /// </summary>
        /// <param name="src">The text to enclose</param>
        [Op]
        public static string squote(object src)
            => enclose(src, CharText.SQuote);

        /// <summary>
        /// Creates a string of the form "lhs := rhs"
        /// </summary>
        /// <param name="lhs">The left</param>
        /// <param name="rhs">The right</param>
        [Op]
        public static string assign(object lhs, object rhs)
            => concat(lhs, Space, Assignment, Space, rhs);

        /// <summary>
        /// Encloses text content between left and right braces
        /// </summary>
        /// <param name="content">The content to be embraced</param>
        [MethodImpl(Inline), Op]
        public static string embrace(string content)
            => $"{Chars.LBrace}{content}{Chars.RBrace}";

        /// <summary>
        /// Encloses text in quotation marks if nonempty; otherwise returns empty
        /// </summary>
        /// <param name="src">The text to be quoted</param>
        [MethodImpl(Inline), Op]
        public static string enquote(string src)
        {
            if(!string.IsNullOrWhiteSpace(src))
                return concat(Chars.Quote, src, Chars.Quote);
            else
                return string.Empty;
        }

        /// <summary>
        /// Encloses content between '(' and ')' characters
        /// </summary>
        /// <param name="content">The items to be enclosed</param>
        [MethodImpl(Inline), Op]
        public static string parenthetical(params object[] content)
            => enclose(string.Concat(content.Select(x => x.ToString())), Chars.LParen, Chars.RParen);

        /// <summary>
        /// Encloses text between '[' and ']' characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline), Op]
        public static string bracket(object content)
            => enclose($"{content}", Chars.LBracket, Chars.RBracket);

        [MethodImpl(Inline), Op]
        public static string rpad(string src, int width, char c = Space)
            => src.PadRight(width, c);

        /// <summary>
        /// Appends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline), Op]
        public static string rspace(object content)
            => $"{content} ";

        /// <summary>
        /// Creates a string of the form "name: content"
        /// </summary>
        /// <param name="name">The label name</param>
        /// <param name="content">The labeled content</param>
        [MethodImpl(Inline), Op]
        public static string label(object name, object content)
            => concat(name, Chars.Colon, Space, content);
    }
}