//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct text
    {
        /// <summary>
        /// Encloses text within (possibly distinct) left and right boundaries
        /// </summary>
        /// <param name="content">The text to be surrounded by the left and right delimiters</param>
        /// <param name="left">The left delimiter</param>
        /// <param name="right">The right delimiter</param>
        [MethodImpl(Inline), Op]
        public static string enclose(object content, char left, char right)
            => concat(left, $"{content}", right);

        /// <summary>
        /// Encloses text between '[' and ']' characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline), Op]
        public static string bracket(object content)
            => enclose($"{content}", Chars.LBracket, Chars.RBracket);

        /// <summary>
        /// Encloses the supplied text in quotation marks
        /// </summary>
        /// <param name="content">The content to be quoted</param>
        [MethodImpl(Options), Op]
        public static string enquote(object content)
            => $"{Chars.Quote}{content}{Chars.Quote}";

        /// <summary>
        /// Produces "..." where count has the default value of 3
        /// </summary>
        [MethodImpl(Options), Op]
        public static string dots(int count = 3)
            => new string(Chars.Dot, count);

        /// <summary>
        /// Produces an indented string
        /// </summary>
        /// <param name="offset">The left indentation offset </param>
        [MethodImpl(Options), Op]
        public static string indented(string content, int offset = 4)
            => content + new string(Chars.Space, offset);

        /// <summary>
        /// Produces a string containing a specified number of spaces
        /// </summary>
        /// <param name="count">The number of spaces the output string should contain</param>
        [MethodImpl(Options), Op]
        public static string spaces(int count = 3)
            => new string(Chars.Space, count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static string rpad<T>(T src, int width, char c = Space)
            => src is null ? EmptyString :  src.ToString().PadRight(width, c);

        [MethodImpl(Options), Op]
        public static string rpad(object src, int width, char c = Space)
            => $"{src}".PadRight(width, c);

        [MethodImpl(Options), Op]
        public static string rpad(char src, int width, char c = Space)
            => $"{src}".PadRight(width, c);

        /// <summary>
        /// Produces a quote
        /// </summary>
        [MethodImpl(Options), Op]
        public static string quote(string content)
            => $"{Chars.Quote}{content}{Chars.Quote}";

        /// <summary>
        /// Appends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline), Op]
        public static string rspace(object content)
            => $"{content} ";

        /// <summary>
        /// Prepends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Options), Op]
        public static string lspace(object content)
            => $" {content}";

        /// <summary>
        /// Encloses text content between left and right braces
        /// </summary>
        /// <param name="content">The content to be embraced</param>
        [MethodImpl(Inline), Op]
        public static string embrace(string content)
            => $"{Chars.LBrace}{content}{Chars.RBrace}";
    }
}