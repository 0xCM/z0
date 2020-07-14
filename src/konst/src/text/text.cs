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

    public static partial class text
    {
        public const string PageBreak = "--------------------------------------------------------------------------------------------------------------";

        const string Assignment = ":=";

        public const string Empty = "";

        /// <summary>
        /// Creates a new stringbuilder
        /// </summary>
        public static StringBuilder build()
            => EmptyString.Build();
        
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

        public static IEnumerable<string> items<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());                

        /// <summary>
        /// Creates a string of the form "lhs := rhs"
        /// </summary>
        /// <param name="lhs">The left</param>
        /// <param name="rhs">The right</param>
        public static string assign(object lhs, object rhs)
            => concat(lhs, Space, Assignment, Space, rhs);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => sys.nonempty(src);

        /// <summary>
        /// Test whether the source is a nonempty string
        /// </summary>
        /// <param name="src">The object to evaluate</param>
        [MethodImpl(Inline)]
        public static bool nonempty(object src) 
            => src is string s ? sys.nonempty(s) : false;
        
        [MethodImpl(Inline)]
        public static object clean(object src)
            => src is string s ? (blank(s) ? EmptyString  : s) : (src ?? EmptyString);
        
        /// <summary>
        /// Tests whether the source string is blank := {null | empty}
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool blank(string src)
            => sys.blank(src);

        /// <summary>
        /// Returns the replacement text if the source text is blank := {null | empty}
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string ifblank(string test, string replace)
            => z.ifblank(test,replace);

        /// <summary>
        /// If the test string is null, returns the empty string; otherwise, returns the test string
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string denullify(string test)
            => blank(test) ? EmptyString : test;

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        public static string slice(string src, int startidx)
            => denullify(src).Substring(startidx);        

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        /// <param name="length">The substring length</param>
        public static string slice(string src, int startidx, int length)
            => denullify(src).Substring(startidx, length);        

        /// <summary>
        /// Splits the string, removing empty entries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="sep">The delimiter</param>
        public static string[] split(string src, char sep)
            => denullify(src).Split(sep, StringSplitOptions.RemoveEmptyEntries);        

        [MethodImpl(Inline)]
        public static bool equals(string a, string b, bool cased = false)
            => string.Equals(a,b, cased ? StringComparison.InvariantCulture : NoCase);

        [MethodImpl(Inline)]
        public static int compare(string a, string b)
            => denullify(a).CompareTo(b);
                
        public static string lines(params string[] content)
        {
            var builder = build();
            foreach(var item in content)
                builder.AppendLine(item);
            return builder.ToString();
        }

        [MethodImpl(Inline)]
        public static T? unvalued<T>()
            where T : struct
                => (T?)null;

        /// <summary>
        /// Returns the indices of the first occurrences of the first and second characters in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>
        public static (int first, int second) indices(string src, char first, char second)
            => (src.IndexOf(first), src.IndexOf(second));

        /// <summary>
        /// Returns the indices of the first occurrences of the first and second strings in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>
        public static (int first, int second) indices(string src, string first, string second)
            => (src.IndexOf(first), src.IndexOf(second));
    
        /// <summary>
        /// Determines whether the source text is of the form "[{content}]"
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        public static bool bracketed(string src)    
            => fenced(src, Chars.LBracket, Chars.RBracket);

        /// <summary>
        /// Removes a substring from the subject
        /// </summary>
        [MethodImpl(Inline)]
        public static string remove(string text, string substring)
            => text.Replace(substring, String.Empty);

        /// <summary>
        /// Returns a substring identified by inclusive indices
        /// </summary>
        /// <param name="src"></param>
        /// <param name="i0">The index of the first character in the substring</param>
        /// <param name="i1">The index of the last character in the substring</param>
        public static string segment(string src, int i0, int i1)
            => src.Substring(i0, i1 - i0 + 1);

        /// <summary>
        /// Returns the substring [0,chars-1]
        /// </summary>
        public static string left(string src, int chars)
            => blank(src) ? src : src.Substring(0, src.Length < chars ? src.Length : chars);

        public static string right(string src, int chars)
        {
            if (blank(src))
                return src;

            var len = src.Length < chars ? src.Length : chars;
            var dst = new char[len];
            for (var i = 0; i < len; i++)
                dst[i] = src[src.Length - len + i];
            return new string(dst);
        } 

 
        [MethodImpl(Inline)]
        public static int width<E>(E field)
            where E : unmanaged, Enum
        {
            var w = scalar<E,uint>(field) >> 16;
            return (int)w;
        }
    }
}