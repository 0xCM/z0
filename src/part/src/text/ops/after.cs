//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        /// <summary>
        /// Selects the substring after the first ocurrence of a specified character it is found in the string; otherwise,
        /// returns the <see cref='EmptyString'/>
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="match">The marking character</param>
        [Op]
        public static string after(string src, char match)
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

            return found != -1 ?  text.substring(src, found + 1) : src;
        }

        [Op]
        public static string after(string src, string match)
        {
            var found = src.IndexOf(match);
            return found != -1 ? text.substring(src,found + match.Length) : src;
        }

        [Op]
        public static bool after(string src, string match, out string result)
        {
            var found = src.IndexOf(match);
            if(found == NotFound)
            {
                result = EmptyString;
                return false;
            }
            else
            {
                result = text.substring(src,found + match.Length);
                return true;
            }
        }
    }
}