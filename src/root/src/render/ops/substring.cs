//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RP
    {
        [MethodImpl(Inline), Op]
        public static string substring(string src, int startidx)
            => src?.Substring(startidx) ?? EmptyString;

        [MethodImpl(Inline), Op]
        public static string substring(string src, int startidx, int len)
            => src?.Substring(startidx, len) ?? EmptyString;

        [Op]
        public static string after(string src, char match)
        {
            var i = src.IndexOf(match);
            return i != NotFound ? substring(src, i + 1) : EmptyString;
        }

        [Op]
        public static string after(string src, string match)
        {
            var i = src.IndexOf(match);
            return i != -1 ? substring(src, i + match.Length) : EmptyString;
        }

        /// <summary>
        /// Selects the substring prior to the first occurrence of a specified character if it is found in the string; otherwise,
        /// returns the original string
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="match">The marking character</param>
        [Op]
        public static string before(string src, char match)
        {
            var found = -1;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                if(src[i] == match)
                {
                    found = i;
                    break;
                }
            }
            return found != -1 ? substring(src, 0, found) : src;
        }

        [Op]
        public static string between(string src, char left, char right)
        {
            var result = string.Empty;
            var i1 = src.IndexOf(left);
            if(i1 != -1)
            {
                var i2 = src.IndexOf(right, i1 + 1);
                if(i2 != -1)
                    result = substring(src,i1 + 1, i2 - i1 - 1);
            }
            return result;
        }
    }
}
