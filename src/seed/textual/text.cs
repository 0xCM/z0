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

    public static class text
    {
        public const string PageBreak = "--------------------------------------------------------------------------------------------------------------";

        public const string Assignment = ":=";

        public const string Empty = "";

        const char lparen = Chars.LParen;

        const char rparen = Chars.RParen;

        public const char dot = Chars.Dot;

        public const char comma = Chars.Comma;

        /// <summary>
        /// Renders an end-of-line marker
        /// </summary>
        public const string Eol = Chars.Eol;
        
        /// <summary>
        /// The non-null empty string
        /// </summary>
        public const string blank = "";

        /// <summary>
        /// Produces a space character 
        /// </summary>
        [MethodImpl(Inline)]
        public static char space()
            => Chars.Space;

        /// <summary>
        /// Creates a new stringbuilder
        /// </summary>
        public static StringBuilder build()
            => string.Empty.Build();
        
        /// <summary>
        /// Creates a string of the form "lhs := rhs"
        /// </summary>
        /// <param name="lhs">The left</param>
        /// <param name="rhs">The right</param>
        public static string assign(object lhs, object rhs)
            => concat(lhs, Chars.Space, Assignment, Chars.Space, rhs);

        /// <summary>
        /// Creates a string of the form "name: content"
        /// </summary>
        /// <param name="name">The label name</param>
        /// <param name="content">The labeled content</param>
        public static string label(object name, object content)
            => concat(name, Chars.Colon, Chars.Space, content);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// A string-specific coalescing operation
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string ifempty(string test, string replace)
            => Root.ifempty(test,replace);

        /// <summary>
        /// If the test string is null, returns the empty string; otherwise, returns the test string
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string denullify(string test)
            => empty(test) ? string.Empty : test;

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        [MethodImpl(Inline)]
        public static string slice(string src, int startidx)
            => denullify(src).Substring(startidx);        

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline)]
        public static string slice(string src, int startidx, int length)
            => denullify(src).Substring(startidx,length);        

        /// <summary>
        /// Splits the string, removing empty entries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="sep">The delimiter</param>
        [MethodImpl(Inline)]
        public static string[] split(string src, char sep)
            => denullify(src).Split(sep, StringSplitOptions.RemoveEmptyEntries);        

        [MethodImpl(Inline)]
        public static bool equals(string a, string b, bool cased = false)
            => string.Equals(a,b, cased ? StringComparison.InvariantCulture : NoCase);

        [MethodImpl(Inline)]
        public static int compare(string a, string b)
            => denullify(a).CompareTo(b);

        /// <summary>
        /// Creates a stream of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        public static ReadOnlySpan<char> replicate(char src, int count)
            => new string(src,count);        

        /// <summary>
        /// Repeats a string a specified number of times
        /// </summary>
        /// <param name="src">The text content to replicate</param>
        /// <param name="count">The number of copies to produce</param>
        public static IEnumerable<string> replicate(string src, int count)
            => src.Replicate(count);

        /// <summary>
        /// Concatenates a sequence of values with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(IEnumerable<object> src)    
            => string.Concat(src);

        /// <summary>
        /// Concatenates a sequence of characters with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(IEnumerable<char> src)
            => src.Concat();

        /// <summary>
        /// Formats a custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string format<T>(T src)
            where T : ITextual
                => denullify(src?.Format());

        /// <summary>
        /// Produces a sequence of formatted strings given a sequence of custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<string> format<T>(IEnumerable<T> src)
            where T : ITextual
                => src.Select(x => x.Format());

        public static string format<T>(IEnumerable<T> src, string delimiter = null)
            where T : ITextual
        {
            var dst =build();
            var count = 0;
            var sep = denullify(delimiter);
            void append(T item)
            {
                if(count != 0)
                    dst.Append(sep);
                 dst.Append(item.Format());   
            }

            return dst.ToString();            
        }

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
        /// Formats the content with a space on either side
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline)]
        public static string spaced(object content)
            => $" {content} ";

        public static string spaced(char c)
            => concat(Chars.Space, c, Chars.Space);

        /// <summary>
        /// Separates each item with a space
        /// </summary>
        public static string spaced(IEnumerable<object> items)
            => string.Join(space(), items);


        /// <summary>
        /// Concatenates a sequence of strings intersprsed by a character delimiter with a space on either side
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string join(char sep, params object[] src)
            => string.Join(spaced(sep), src);

        /// <summary>
        /// Concatenates a sequence of strings intersprsed by a character delimiter with a space on either side
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(char sep, IEnumerable<object> src)
            => string.Join(spaced(sep), src);

        /// <summary>
        /// Joins the string representation of a sequence of items interspersed by a separator
        /// </summary>
        /// <param name="sep">The value delimiter</param>
        /// <param name="src">The values to be joined</param>
        public static string concat(string sep, IEnumerable<object> src)
            => string.Join(sep, src);

        /// <summary>
        /// Joins the string representation of a sequence of items with no interspersed separator
        /// </summary>
        /// <param name="src">The values to be joined</param>
        public static string concat(params object[] src)    
            => string.Concat(src);

        public static string concat(string sep, ReadOnlySpan<string> src)
        {
            var builder = build();
            var lastix = src.Length - 1;
            for(var i=0; i<src.Length; i++)        
            {
                builder.Append(src[i]);
                if(i != lastix)
                    builder.Append(sep);
            }
            return builder.ToString();
        }

        public static string concat(string sep, Span<string> src)
            => concat(sep, (ReadOnlySpan<string>)src);

        public static string lines(params string[] content)
        {
            var builder = build();
            foreach(var item in content)
                builder.AppendLine(item);
            return builder.ToString();
        }


        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string intersperse(string src, char c)
            => src.Intersperse(c);

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        public static string intersperse(string src, string sep)
            => src.Intersperse(sep);
            
        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
        [MethodImpl(Inline)]   
        internal static Y apply<X,Y>(X x,Func<X,Y> f)
            => f(x);

        [MethodImpl(Inline)]
        internal static T? unvalued<T>()
            where T : struct
                => (T?)null;

        public static IEnumerable<string> items<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());                

        /// <summary>
        /// Encloses text content between left and right braces
        /// </summary>
        /// <param name="content">The content to be embraced</param>
        [MethodImpl(Inline)]
        public static string embrace(string content)      
            => $"{LBrace}{content}{RBrace}";

        /// <summary>
        /// Produces a line of content
        /// </summary>
        /// <param name="content">The line content</param>
        [MethodImpl(Inline)]
        public static string line(string content)
            => content + Eol;

        /// <summary>
        /// Encloses the supplied text in quotation marks
        /// </summary>
        /// <param name="content">The content to be quoted</param>
        [MethodImpl(Inline)]
        public static string enquote(object content)
            => $"{Chars.Quote}{content}{Chars.Quote}";

        /// <summary>
        /// Encloses text within (possibly distinct) left and right boundaries
        /// </summary>
        /// <param name="content">The text to be bounded</param>
        /// <param name="left">The text on the left</param>
        /// <param name="right">The text on the right</param>
        [MethodImpl(Inline)]
        public static string enclose(object content, string left, string right)
            => string.Concat(left, $"{content}", right);


        /// <summary>
        /// Encloses text within a bounding string
        /// </summary>
        /// <param name="content">The text to enclose</param>
        /// <param name="sep">The left and right boundary</param>
        [MethodImpl(Inline)]
        public static string enclose(object content, string sep)
            => string.Concat(sep,$"{content}",sep);

        /// <summary>
        /// Encloses a character within uniform left/right bounding string
        /// </summary>
        /// <param name="content">The character to be surrounded by the left and right delimiters</param>
        /// <param name="sep">The boundary delimiter</param>
        [MethodImpl(Inline)]
        public static string enclose(char content, string sep)
            => string.Concat(sep,content,sep);

        /// <summary>
        /// Encloses a character within (possibly distinct) left and right boundaries
        /// </summary>
        /// <param name="content">The character to be bounded</param>
        /// <param name="left">The text on the left</param>
        /// <param name="right">The text on the right</param>
        [MethodImpl(Inline)]
        public static string enclose(char content, string left, string right)
            => string.Concat(left,content,right);

        /// <summary>
        /// Encloses text between single quote (') characters
        /// </summary>
        /// <param name="src">The text to enclose</param>
        [MethodImpl(Inline)]
        public static string squote(object src)
            => enclose(src, CharText.SQuote);

        /// <summary>
        /// Encloses content between '(' and ')' characters
        /// </summary>
        /// <param name="content">The items to be enclosed</param>
        [MethodImpl(Inline)]
        public static string parenthetical(params object[] content)
            => enclose(string.Concat(content.Select(x => x.ToString())), lparen, rparen);

        /// <summary>
        /// Encloses content between '(' and ')' where items are interspersed with a separator
        /// </summary>
        /// <param name="content">The items to be enclosed</param>
        [MethodImpl(Inline)]
        public static string parenthetical(char sep, params object[] content)
            => enclose(concat(sep,content.Select(x => x.ToString())), lparen, rparen);

        /// <summary>
        /// Renders a content array as a comma-separated list of values
        /// </summary>
        /// <param name="content">The data to delimit and format</param>
        [MethodImpl(Inline)]
        public static string csv(object o1, object o2, params object[] content)
            => string.Join(Chars.Comma, o1, o2) + string.Join(Chars.Comma, content);

        /// <summary>
        /// Renders each item from a sequence as list of values, delimited by end-of-line
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline)]
        public static string line(IEnumerable<object> content)
            => string.Join(Chars.Eol, content);

        /// <summary>
        /// Encloses text within (possibly distinct) left and right boundaries
        /// </summary>
        /// <param name="content">The text to be surrounded by the left and right delimiters</param>
        /// <param name="left">The left delimiter</param>
        /// <param name="right">The right delimiter</param>
        [MethodImpl(Inline)]
        public static string enclose(object content, char left, char right)
            => string.Concat(left, $"{content}", right);

        /// <summary>
        /// Encloses text between '[' and ']' characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline)]
        public static string bracket(object content)
            => enclose($"{content}", Chars.LBracket, Chars.RBracket);

        /// <summary>
        /// Determines whether the source text is of the form {left:char}{content:string}{right:char},
        /// ignoring leading/trailing whitespace
        /// </summary>
        /// <param name="src">The text to analyze</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        public static bool fenced(string src, char left, char right)
        {
            if(empty(src))
                return false;
            
            var x = src.Trim();
            var length = x.Length;
            return 
                x[0] == left 
             && x[length - 1] == right;
        }

        /// <summary>
        /// Returns the index of the first occurrence of the first character and the first occurrence of the second character
        /// </summary>
        /// <param name="src">The source thext</param>
        /// <param name="first">The first index match</param>
        /// <param name="second">THe second index match</param>
        public static (int first, int second) indices(string src, char first, char second)
            => (src.IndexOf(first), src.IndexOf(second));

        /// <summary>
        /// If fenced with specified left and right characters, extracts the enclosed content; otherwise, returns the content unmolested
        /// </summary>
        /// <param name="src">The putative fenced content</param>
        public static string unfence(string src, char left, char right)
        {
            if(empty(src))
                return string.Empty;

            if(!fenced(src,left,right))
                return src;
                
            var data = src.Trim();
            var length = data.Length;
            return data.Substring(1, length - 2);
        }

        /// <summary>
        /// Determines whether the source text is of the form "[{content}]"
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        public static bool bracketed(string src)    
            => fenced(src,Chars.LBracket, Chars.RBracket);

        /// <summary>
        /// If bracketed, extracts the enclosed content; otherwise, returns the empty string
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        public static string unbracket(string src)
            => unfence(src,Chars.LBracket,Chars.RBracket);

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
                return concat(Chars.Quote, src, Chars.Quote);
            else
                return string.Empty;
        }

        /// <summary>
        /// Returns a substring identified by inclusive indices
        /// </summary>
        /// <param name="src"></param>
        /// <param name="i0">The index of the first character in the substring</param>
        /// <param name="i1">The index of the last character in the substring</param>
        public static string segment(string src, int i0, int i1)
            => src.Substring(i0, i1 - i0 + 1);

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

        /// <summary>
        /// Allocates a stream over a string
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="encoding">The text encoding</param>
        public static MemoryStream stream(string src, Encoding encoding = null)
        {
            var bytes = (encoding ?? Encoding.UTF8).GetBytes(src ?? string.Empty);            
            return new MemoryStream(bytes);
        }

        [MethodImpl(Inline)]
        public static int width<E>(E field)
            where E : unmanaged, Enum
        {
            var w = Root.tVal<E,uint>(field) >> 16;
            return (int)w;
        }

        /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        public static string list<T>(ReadOnlySpan<T> src, char sep = Chars.Comma, int offset = 0)
            where T : ITextual
        {
            if(src.Length == 0)
                return string.Empty;
            
            var dst = new StringBuilder();
            
            for(var i = offset; i< src.Length; i++)
            {
                if(i!=offset)
                {
                    dst.Append(sep);
                    dst.Append(Chars.Space);
                }
                dst.Append(src[i].Format());
            }
            return dst.ToString();
        }


        /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [MethodImpl(Inline)]        
        public static string list<T>(IEnumerable<T> src, char? delimiter = null, int offset = 0)
            where T : ITextual
                => string.Join(delimiter ?? Chars.Comma, src.Skip(0).Select(x => x.Format()));                

        [MethodImpl(Inline)]
        public static string numeric<F>(F src)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src);

        [MethodImpl(Inline)]
        public static string numeric<F>(F src, NumericBaseKind @base)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src, @base);

        [MethodImpl(Inline)]
        public static string hex<T>(T src)
            where T : unmanaged
                => SystemHexFormatters.Create<T>().Format(src);
    }
}