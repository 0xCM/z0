//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static AsciSym;

    partial class text
    {
        /// <summary>
        /// Renders an end-of-line marker
        /// </summary>
        [MethodImpl(Inline)]   
        public static string eol() 
            => AsciEscape.Eol;

        /// <summary>
        /// Encloses text content between left and right braces
        /// </summary>
        /// <param name="content">The content to be embraced</param>
        [MethodImpl(Inline)]
        public static string embrace(string content)      
            => $"{LBrace}{content}{RBrace}";

        /// <summary>
        /// Left-Pads the input string with an optionally-specified character.
        /// </summary>
        /// <param name="src">The input text</param>
        /// <param name="width">The with of the padded string</param>
        /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
        [MethodImpl(Inline)]   
        public static string lpad(string src, int width, char? c = null)
            => src.PadLeft(width,c ?? ' ');

        /// <summary>
        /// Formats the source value and left-pads the result with zeros
        /// </summary>
        /// <param name="src">The input text</param>
        /// <param name="width">The with of the padded string</param>
        [MethodImpl(Inline)]   
        public static string zpad(object src, int width)
            => $"{src}".PadLeft(width, AsciDigits.A0);

        /// <summary>
        /// Right-Pads the input string with an optionally-specified character.
        /// </summary>
        /// <param name="src">The input text</param>
        /// <param name="width">The with of the padded string</param>
        /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
        [MethodImpl(Inline)]   
        public static string rpad(string src, int width, char? c = null)
            => src.PadRight(width, c ?? AsciSym.Space);

        /// <summary>
        /// Produces a left parenthesis character
        /// </summary>
        [MethodImpl(Inline)]
        public static string lparen()
            => "(";

        /// <summary>
        /// Produces a '[' character
        /// </summary>
        [MethodImpl(Inline)]
        public static char lbracket()
            => AsciSym.LBracket;

        /// <summary>
        /// Produces a ']' character
        /// </summary>
        [MethodImpl(Inline)]
        public static char rbracket()
            => AsciSym.RBracket;

        /// <summary>
        /// Produces a right parenthesis character
        /// </summary>
        [MethodImpl(Inline)]
        public static string rparen()
            => ")";

        /// <summary>
        /// Produces a quote
        /// </summary>
        [MethodImpl(Inline)]
        public static char quote()
            => AsciSym.Quote;

        /// <summary>
        /// Produces a quote
        /// </summary>
        public static string quote(string content)
            => $"{quote()}{content}{quote()}";

        /// <summary>
        /// Produces a space character 
        /// </summary>
        [MethodImpl(Inline)]
        public static char space()
            => AsciSym.Space;

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
        /// Formats the content with a space on either side
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline)]
        public static string spaced(object content)
            => $" {content} ";

        public static string spaced(char c)
            => concat(AsciSym.Space, c, AsciSym.Space);

        /// <summary>
        /// Separates each item with a space
        /// </summary>
        public static string spaced(IEnumerable<object> items)
            => string.Join(space(), items);

        /// <summary>
        /// Produces a '|' character
        /// </summary>
        [MethodImpl(Inline)]
        public static char pipe()
            => AsciSym.Pipe;

        /// <summary>
        /// Produces a '-' character
        /// </summary>
        [MethodImpl(Inline)]
        public static string dash()
            => AsciSym.Dash.ToString();

        /// <summary>
        /// Produces a ',' character
        /// </summary>
        [MethodImpl(Inline)]
        public static char comma()
            => AsciSym.Comma;

        /// <summary>
        /// Produces a left-brace character as a string
        /// </summary>
        [MethodImpl(Inline)]
        public static string lbrace() => "{";

        /// <summary>
        /// Produces a right-brace character as a string
        /// </summary>
        [MethodImpl(Inline)]
        public static string rbrace() => "}";

        /// <summary>
        /// Produces a '/' character
        /// </summary>
        [MethodImpl(Inline)]
        public static string fslash()
            => AsciSym.FSlash.ToString();

        /// <summary>
        /// Produces a '\' character
        /// </summary>
        [MethodImpl(Inline)]
        public static string bslash()
            => AsciSym.BSlash.ToString();

        /// <summary>
        /// Produces a ";" character
        /// </summary>
        public static string semicolon()
            => AsciSym.Semicolon.ToString();

        /// <summary>
        /// Produces a "." character
        /// </summary>
        [MethodImpl(Inline)]
        public static string dot()
            => AsciSym.Dot.ToString();

        /// <summary>
        /// Produces a ':' character
        /// </summary>
        [MethodImpl(Inline)]
        public static char colon()
            => AsciSym.Colon;

        /// <summary>
        /// Produces a line of content
        /// </summary>
        /// <param name="content">The line content</param>
        [MethodImpl(Inline)]
        public static string line(string content)
            => content + eol();

        /// <summary>
        /// Encloses the supplied text in quotation marks
        /// </summary>
        /// <param name="content">The content to be quoted</param>
        [MethodImpl(Inline)]
        public static string enquote(object content)
            => $"{AsciSym.Quote}{content}{AsciSym.Quote}";

        /// <summary>
        /// Encloses text within (possibly distinct) left and right boundaries
        /// </summary>
        /// <param name="content">The text to be bounded</param>
        /// <param name="left">The text on the left</param>
        /// <param name="right">The text on the right</param>
        [MethodImpl(Inline)]
        public static string enclose(object content, string left, string right)
            => concat(left, $"{content}", right);

        /// <summary>
        /// Encloses text within (possibly distinct) left and right boundaries
        /// </summary>
        /// <param name="content">The text to be surrounded by the left and right delimiters</param>
        /// <param name="left">The left delimiter</param>
        /// <param name="right">The right delimiter</param>
        [MethodImpl(Inline)]
        public static string enclose(object content, char left, char right)
            => concat(left, $"{content}", right);

        /// <summary>
        /// Encloses text within a bounding string
        /// </summary>
        /// <param name="content">The text to enclose</param>
        /// <param name="sep">The left and right boundary</param>
        [MethodImpl(Inline)]
        public static string enclose(object content, string sep)
            => concat(sep,$"{content}",sep);

        /// <summary>
        /// Encloses a character within uniform left/right bounding string
        /// </summary>
        /// <param name="content">The character to be surrounded by the left and right delimiters</param>
        /// <param name="sep">The boundary delimiter</param>
        [MethodImpl(Inline)]
        public static string enclose(char content, string sep)
            => concat(sep,content,sep);

        /// <summary>
        /// Encloses a character within (possibly distinct) left and right boundaries
        /// </summary>
        /// <param name="content">The character to be bounded</param>
        /// <param name="left">The text on the left</param>
        /// <param name="right">The text on the right</param>
        [MethodImpl(Inline)]
        public static string enclose(char content, string left, string right)
            => concat(left,content,right);

        /// <summary>
        /// Encloses text between single quote (') characters
        /// </summary>
        /// <param name="src">The text to enclose</param>
        [MethodImpl(Inline)]
        public static string squote(object src)
            => enclose(src, AsciSym.SQuote.ToString());

        /// <summary>
        /// Encloses content between '(' and ')' characters
        /// </summary>
        /// <param name="content">The items to be enclosed</param>
        [MethodImpl(Inline)]
        public static string parenthetical(params object[] content)
            => enclose(concat(content.Select(x => x.ToString())), lparen(), rparen());

        /// <summary>
        /// Encloses content between '(' and ')' where items are interspersed with a separator
        /// </summary>
        /// <param name="content">The items to be enclosed</param>
        [MethodImpl(Inline)]
        public static string parenthetical(char sep, params object[] content)
            => enclose(concat(sep,content.Select(x => x.ToString())), lparen(), rparen());

        /// <summary>
        /// Renders a content array as a comma-separated list of values
        /// </summary>
        /// <param name="content">The data to delimit and format</param>
        [MethodImpl(Inline)]
        public static string csv(object o1, object o2, params object[] content)
            =>  string.Join(AsciSym.Comma, o1, o2) + string.Join(AsciSym.Comma, content);

        /// <summary>
        /// Renders each item from a sequence as list of values, delimited by end-of-line
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline)]
        public static string eol(IEnumerable<object> content)
            => string.Join(eol(), content);

        /// <summary>
        /// Encloses text between '[' and ']' characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline)]
        public static string bracket(object content)
            => enclose($"{content}", lbracket(), rbracket());

        /// <summary>
        /// Encloses text between less than and greater than characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline)]
        public static string angled(string content)
            => String.IsNullOrWhiteSpace(content) ? string.Empty : $"<{content}>";

        /// <summary>
        /// Trims leading characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [MethodImpl(Inline)]
        public static string ltrim(string src, params char[] chars)
            => empty(src) ? string.Empty : src.TrimStart(chars);

        /// <summary>
        /// Trims trailing characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [MethodImpl(Inline)]
        public static string rtrim(string src, params char[] chars)
            => empty(src) ? string.Empty : src.TrimEnd(chars);

        /// <summary>
        /// Produces "..." where count has the default value of 3
        /// </summary>
        [MethodImpl(Inline)]
        public static string dots(int count = 3)
            => new string(AsciSym.Dot, count);

        /// <summary>
        /// Produces an indented string
        /// </summary>
        /// <param name="offset">The left indentation offset </param>
        [MethodImpl(Inline)]
        public static string indented(string content, int offset = 4)
            => content + new string(AsciSym.Space, offset);

        /// <summary>
        /// Produces a string containing a specified number of spaces
        /// </summary>
        /// <param name="count">The number of spaces the output string should contain</param>
        [MethodImpl(Inline)]
        public static string spaces(int count = 3)
            => new string(AsciSym.Space, count);

        /// <summary>
        /// Removes a substring from the subject
        /// </summary>
        [MethodImpl(Inline)]
        public static string remove(string text, string substring)
            => text.Replace(substring, String.Empty);

        /// <summary>
        /// Encloses text in quotation marks if nonempty; otherwirse returns empty
        /// </summary>
        /// <param name="src">The text to be quoted</param>
        public static string enquote(string src)
        {
            if(!string.IsNullOrWhiteSpace(src))
                return concat(AsciSym.Quote, src, AsciSym.Quote);
            else
                return string.Empty;
        }

        /// <summary>
        /// Formats and concatenates an arbitrary number of elements
        /// </summary>
        /// <param name="rest">The formattables to be rendered and concatenated</param>
        public static string format(object first, params object[] rest)
            => first.ToString() + concat(rest.Select(x => x.ToString()));
        
        /// <summary>
        /// Returns the substring [0,chars-1]
        /// </summary>
        public static string left(string src, int chars)
            => empty(src) ? src : src.Substring(0, src.Length < chars ? src.Length : chars);

        public static string right(string src, int chars)
        {
            if (empty(src))
                return src;

            var len = src.Length < chars ? src.Length : chars;
            var dst = new char[len];
            for (var i = 0; i < len; i++)
                dst[i] = src[src.Length - len + i];
            return new string(dst);
        }
    }
}