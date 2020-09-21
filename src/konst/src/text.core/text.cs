//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
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

        [MethodImpl(Inline), Op]
        public static object clean(object src)
            => src is string s ? (blank(s) ? EmptyString  : s) : (src ?? EmptyString);

        /// <summary>
        /// Returns the replacement text if the source text is blank := {null | empty}
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline), Op]
        public static string ifblank(string test, string replace)
            => z.ifempty(test,replace);

        /// <summary>
        /// Splits the string, removing empty entries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="sep">The delimiter</param>
        [MethodImpl(Inline), Op]
        public static string[] split(string src, char sep)
            => src.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        [MethodImpl(Inline), Op]
        public static int compare(string a, string b)
            => a.CompareTo(b);

        /// <summary>
        /// Appends each source items to a target stream, appending an EOL after each
        /// </summary>
        /// <param name="content"></param>
        [Op]
        public static string lines(params string[] content)
        {
            var builder = build();
            foreach(var item in content)
                builder.AppendLine(item);
            return builder.ToString();
        }

        /// <summary>
        /// Returns the indices of the first occurrences of the first and second characters in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>

        [MethodImpl(Inline), Op]
        public static (int first, int second) indices(string src, char first, char second)
            => (src.IndexOf(first), src.IndexOf(second));

        /// <summary>
        /// Returns the indices of the first occurrences of the first and second strings in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>
        [MethodImpl(Inline), Op]
        public static (int first, int second) indices(string src, string first, string second)
            => (src.IndexOf(first), src.IndexOf(second));

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