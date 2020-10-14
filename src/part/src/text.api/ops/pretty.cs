//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;

    partial struct text
    {
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

        [MethodImpl(Options), Op, Closures(UnsignedInts)]
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
        /// Prepends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Options), Op]
        public static string lspace(object content)
            => $" {content}";
    }
}