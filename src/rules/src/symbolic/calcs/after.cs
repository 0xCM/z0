//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    readonly partial struct SymbolicCalcs
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> after(ReadOnlySpan<char> src, char match)
        {
            var i =  src.IndexOf(match);
            return i != NotFound ? slice(src,i + 1) : default;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> after(ReadOnlySpan<char> src, ReadOnlySpan<char> match)
        {
            var i = src.IndexOf(match);
            return i != NotFound ? slice(src, i + match.Length) : default;
        }

        /// <summary>
        /// Selects the substring after the first ocurrence of a specified character it
        /// is found in the string; otherwise, returns the <see cref='EmptyString'/>
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="match">The marking character</param>
        [Op]
        public static string after(string src, char match)
        {
            var i = src.IndexOf(match);
            return i != NotFound ? text.substring(src, i + 1) : EmptyString;
        }

        [Op]
        public static string after(string src, string match)
        {
            var i = src.IndexOf(match);
            return i != -1 ? text.substring(src, i + match.Length) : EmptyString;
        }

        [Op]
        public static bool after(string src, string match, out string result)
        {
            var i = src.IndexOf(match);
            result = i == NotFound ? EmptyString : text.substring(src, i + match.Length);
            return i != NotFound;
        }
    }
}