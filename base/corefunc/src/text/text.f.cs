//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;

using Z0;
using static Z0.AsciSym;
using static Z0.AsciEscape;
using static Z0.AsciDigits;

partial class zfunc
{ 
    static readonly ConcurrentDictionary<string, Regex> _regexCache
        = new ConcurrentDictionary<string, Regex>();

    /// <summary>
    /// The empty string
    /// </summary>    
    public const string blank = "";

    /// <summary>
    /// Renders an end-of-line marker
    /// </summary>
    [MethodImpl(Inline)]   
    public static string eol() 
        => Eol;

    [MethodImpl(Inline)]   
    public static string format<T>(T value)
        where T : struct
            => value.ToString();

    [MethodImpl(Inline)]   
    public static string format(object value)
        =>  value?.ToString() ?? blank;

    [MethodImpl(Inline)]
    public static string format<T>(IEnumerable<T> values, char sep)
        => string.Join(sep,values);

    /// <summary>
    /// Formats a tuple as one would expect
    /// </summary>
    /// <param name="x1">The first coordinate</param>
    /// <param name="x2">The second coordinate</param>
    /// <typeparam name="X1">The first coordinate type</typeparam>
    /// <typeparam name="X1">The second coordinate type</typeparam>
    [MethodImpl(Inline)]
    public static string format<X1,X2>((X1 x1, X2 x2) x)
        => $"({x.x1}, {x.x2})";

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
    /// Left-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    [MethodImpl(Inline)]   
    public static string zpad(string src, int width)
        => src.PadLeft(width,AsciDigits.A0);

    /// <summary>
    /// Formats the source value and left-pads the result with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    [MethodImpl(Inline)]   
    public static string zpad<T>(T src, int width)
        => $"{src}".PadLeft(width, AsciDigits.A0);

    /// <summary>
    /// Right-Pads the input string with an optionally-specified character.
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
    [MethodImpl(Inline)]   
    public static string rpad(string src, int width, char? c = null)
        => src.PadRight(width,c ?? ' ');

    /// <summary>
    /// Right-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    [MethodImpl(Inline)]   
    public static string rpadZ(string src, int width)
        => src.PadRight(width, AsciDigits.A0);

    /// <summary>
    /// Tests whether the source string is empty
    /// </summary>
    /// <param name="src">The string to evaluate</param>
    [MethodImpl(Inline)]
    public static bool empty(string src)
        => String.IsNullOrWhiteSpace(src);

    /// <summary>
    /// Tests whether the source string is nonempty
    /// </summary>
    /// <param name="src">The string to evaluate</param>
    [MethodImpl(Inline)]
    public static bool nonempty(string src)
        => ! String.IsNullOrWhiteSpace(src);

    /// <summary>
    /// Determines whether a string 2-tuple consists of only the empty string
    /// </summary>
    [MethodImpl(Inline)]
    public static bool nonempty((string s1, string s2) s)
        => nonempty(s.s1) || nonempty(s.s2);

    /// <summary>
    /// A string-specific coalescing operation
    /// </summary>
    /// <param name="subject">The subject string</param>
    /// <param name="replace">The replacement value if blank</param>
    [MethodImpl(Inline)]
    public static string ifEmpty(string subject, string replace)
        => empty(subject) ? replace : subject;

    /// <summary>
    /// Replacement returned if the input is not blank
    /// </summary>
    /// <param name="subject">The subject string</param>
    /// <param name="replace">The replacement value if input is not blank</param>
    [MethodImpl(Inline)]
    public static string ifNonempty(string subject, string replace)
        => nonempty(subject) ? replace : subject;

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
    [MethodImpl(Inline)]
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

    [MethodImpl(Inline)]
    public static string spaced(char c)
        => concat(AsciSym.Space, c, AsciSym.Space);

    /// <summary>
    /// Separates each item with a space
    /// </summary>
    [MethodImpl(Inline)]
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
    /// Produces a line of content
    /// </summary>
    /// <param name="content">The line content</param>
    [MethodImpl(Inline)]
    public static string line(string content)
        => content + eol();

    /// <summary>
    /// Produces a line of content for each item in an array
    /// </summary>
    /// <param name="content">An content array</param>
    public static string lines(params string[] content)
    {
        var sb = text();
        foreach(var item in content)
            sb.AppendLine(item);
        return sb.ToString();
    }

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
    /// Renders a content array as a comma-separated list of values
    /// </summary>
    /// <param name="content">The data to delimit and format</param>
    [MethodImpl(Inline)]
    public static string csv(object o1, object o2, params object[] content)
        =>  string.Join(AsciSym.Comma, o1, o2) + string.Join(AsciSym.Comma, content);

    /// <summary>
    /// Renders a sequence of items as a comma-separated list of values
    /// </summary>
    [MethodImpl(Inline)]
    public static string csv(IEnumerable<object> content)
        => string.Join(AsciSym.Comma, content);

    /// <summary>
    /// Renders a sequence of items as an x-separated list of values
    /// </summary>
    /// <param name="sep">The delimiter</param>
    /// <param name="content">The data to delimit and format</param>
    [MethodImpl(Inline)]
    public static string xsv(string sep, params object[] content)
        => string.Join(sep, content);

    /// <summary>
    /// Renders a stream as a comma-separated list of values
    /// </summary>
    /// <param name="src">The source items</param>
    [MethodImpl(Inline)]
    public static string csv<T>(IEnumerable<T> src)
        => string.Join(AsciSym.Comma, src);

    /// <summary>
    /// Renders a stream as a pipe-separated list of values
    /// </summary>
    /// <param name="src">The source items</param>
    [MethodImpl(Inline)]
    public static string psv<T>(IEnumerable<T> src)
        => string.Join(AsciSym.Pipe, src);

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
    /// If input is not blank, returns the input; otherwise, returns an empty string or a supplied marker
    /// </summary>
    /// <param name="subject">The subject</param>
    [MethodImpl(Inline)]
    static string toString(string subject, string ifBlank = null)
        => nonempty(subject) ? subject : ifBlank ?? String.Empty;


    /// <summary>
    /// Defines a symbol
    /// </summary>
    /// <param name="name">The name of the symbol</param>
    /// <param name="description">Formal or informal description depending on context/needs</param>
    [MethodImpl(Inline)]   
    public static Symbol symbol(string name)
        => new Symbol(name);

    /// <summary>
    /// Encloses the potential text in quotation marks
    /// </summary>
    /// <param name="text">The text to be quoted</param>
    [MethodImpl(Inline)]
    public static string enquote(Option<string> text)
        => enquote(text ? text.ValueOrDefault() ?? String.Empty : String.Empty);

    /// <summary>
    /// Formats and concatenates an arbitrary number of elements
    /// </summary>
    /// <param name="rest">The formattables to be rendered and concatenated</param>
    [MethodImpl(Inline)]   
    public static string format(object first, params object[] rest)
        => first.ToString() + concat(rest.Select(x => x.ToString()));

    /// <summary>
    /// Creates a complied regular expression from the supplied pattern
    /// </summary>
    /// <param name="pattern">The regex pattern/></param>
    [MethodImpl(Inline)]
    static Regex regex(string pattern)
        => new Regex(pattern, RegexOptions.Compiled);

    /// <summary>
    /// Creates a complied regular expression and (c)aches it
    /// </summary>
    /// <param name="pattern">The regex pattern/></param>
    [MethodImpl(Inline)]
    public static Regex regexc(string pattern)
        => _regexCache.GetOrAdd(pattern, p => regex(p));
    
    /// <summary>
    /// Constructs a depiction of the empty set, {∅}
    /// </summary>
    [MethodImpl(Inline)]
    public static string emptyset()
        => embrace(MathSym.EmptySet.ToString());

    /// <summary>
    /// Splits the string into delimited and nonempy parts
    /// </summary>
    /// <param name="src">The text to split</param>
    /// <param name="c">The delimiter</param>
    [MethodImpl(Inline)]
    public static IReadOnlyList<string> split(string src, char c)
        => empty(src)
        ? zfunc.array<string>()
        : src.Split(new char[] { c }, StringSplitOptions.RemoveEmptyEntries);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    [MethodImpl(Inline)]
    public static string left(string src, int chars)
        => empty(src)
        ? src
        : src.Substring(0, src.Length < chars ? src.Length : chars);

    /// <summary>
    /// Returns the substring [0,chars-1]
    /// </summary>
    public static string reverse(string src)
    {
        if (empty(src))
            return src;

        var dst = new char[src.Length];
        int j = 0;
        for (var i = src.Length - 1; i >= 0; i--)
            dst[j++] = src[i];
        return new string(dst);
    }

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
    /// Compares two strings using ordinal/case-insensitive comparison
    /// </summary>
    /// <param name="x">The first string</param>
    /// <param name="y">The second string</param>
    [MethodImpl(Inline)]
    public static bool equals(string x, string y)
        => ifEmpty(x, string.Empty).Equals(y, StringComparison.OrdinalIgnoreCase);


    /// <summary>
    /// Joins the string representation of a sequence of values
    /// </summary>
    /// <param name="values">The values to be joined</param>
    /// <param name="sep">The value delimiter</param>
    [MethodImpl(Inline)]
    public static string join(string sep, IEnumerable<object> values)
        => string.Join(sep, values);

    [MethodImpl(Inline)]
    public static StringBuilder text()
        => new StringBuilder();

    public static StringBuilder text(object s)
        => new StringBuilder(s.ToString());

    public static StringBuilder text(char sep, params object[] values)
        => new StringBuilder(join(sep.ToString(), values));

    public static StringBuilder text(string sep, params object[] values)
        => new StringBuilder(join(sep, values));
}