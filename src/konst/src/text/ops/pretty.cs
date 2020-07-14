//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Encloses text content between left and right braces
        /// </summary>
        /// <param name="content">The content to be embraced</param>
        [MethodImpl(Inline)]
        public static string embrace(string content)      
            => $"{LBrace}{content}{RBrace}";

        /// <summary>
        /// Encloses the supplied text in quotation marks
        /// </summary>
        /// <param name="content">The content to be quoted</param>
        [MethodImpl(Inline)]
        public static string enquote(object content)
            => $"{Chars.Quote}{content}{Chars.Quote}";

        /// <summary>
        /// Encloses text in quotation marks if nonempty; otherwirse returns empty
        /// </summary>
        /// <param name="src">The text to be quoted</param>
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
        [MethodImpl(Inline)]
        public static string parenthetical(params object[] content)
            => enclose(string.Concat(content.Select(x => x.ToString())), Chars.LParen, Chars.RParen);

        /// <summary>
        /// Encloses text between single quote (') characters
        /// </summary>
        /// <param name="src">The text to enclose</param>
        [MethodImpl(Inline)]
        public static string squote(object src)
            => enclose(src, CharText.SQuote);
    
        /// <summary>
        /// Encloses text between '[' and ']' characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        public static string bracket(object content)
            => enclose($"{content}", Chars.LBracket, Chars.RBracket);

        /// <summary>
        /// Produces "..." where count has the default value of 3
        /// </summary>
        [MethodImpl(Inline)]
        public static string dots(int count = 3)
            => new string(Chars.Dot, count);

        /// <summary>
        /// Produces an indented string
        /// </summary>
        /// <param name="offset">The left indentation offset </param>
        [MethodImpl(Inline)]
        public static string indented(string content, int offset = 4)
            => content + new string(Chars.Space, offset);

        /// <summary>
        /// Produces a string containing a specified number of spaces
        /// </summary>
        /// <param name="count">The number of spaces the output string should contain</param>
        [MethodImpl(Inline)]
        public static string spaces(int count = 3)
            => new string(Chars.Space, count);

        [MethodImpl(Inline)]
        public static string rpad<T>(T src, int width, char c = Space)
            where T : ITextual
                => src.Format().PadRight(width, c);

        [MethodImpl(Inline)]
        public static string rpad(object src, int width, char c = Space)
            => $"{src}".PadRight(width, c);

        [MethodImpl(Inline)]
        public static string rpad(string src, int width, char c = Space)
            => src.PadRight(width, c);

        [MethodImpl(Inline)]
        public static string rpad(char src, int width, char c = Space)
            => $"{src}".PadRight(width, c);

        /// <summary>
        /// Produces a quote
        /// </summary>
        public static string quote(string content)
            => $"{Chars.Quote}{content}{Chars.Quote}";

        /// <summary>
        /// Prepends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline)]
        public static string lspace(object content)
            => $" {content}";

        /// <summary>
        /// Appends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline)]
        public static string rspace(object content)
            => $"{content} ";

        /// <summary>
        /// Creates a string of the form "name: content"
        /// </summary>
        /// <param name="name">The label name</param>
        /// <param name="content">The labeled content</param>
        public static string label(object name, object content)
            => concat(name, Colon, Space, content);

        /// <summary>
        /// Trims leading characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [MethodImpl(Inline)]
        public static string ltrim(string src, params char[] chars)
            => blank(src) ? string.Empty : src.TrimStart(chars);

        /// <summary>
        /// Trims trailing characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [MethodImpl(Inline)]
        public static string rtrim(string src, params char[] chars)
            => blank(src) ? string.Empty : src.TrimEnd(chars);

        /// <summary>
        /// Produces a line of content
        /// </summary>
        /// <param name="content">The line content</param>
        [MethodImpl(Inline)]
        public static string line(string content)
            => content + Eol;

        /// <summary>
        /// Renders each item from a sequence as list of values, delimited by end-of-line
        /// </summary>
        /// <param name="content">The content to enclose</param>
        public static string line(IEnumerable<object> content)
            => string.Join(Chars.Eol, content);

    }
}