//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    partial class TextExtensions
    {
        /// <summary>
        /// Selects the substring prior to the first occurrence of a specified character if it is found in the string; otherwise, 
        /// returns the original string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The marking character</param>
        public static string TakeBefore(this string s, char c)
        {
            var found = -1;
            for(var i=0; i<s.Length; i++)
            {
                if(s[i] == c)
                {
                    found = i;
                    break;
                }
            }
            return found != -1 ? s.Substring(0, found) : s;
        }

        /// <summary>
        /// Selects the substring after the first ocurrence of a specified character it is found in the string; otherwise, 
        /// returns the original string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The marking character</param>
        public static string TakeAfter(this string s, char c)
        {
            var found = -1;
            for(var i=0; i<s.Length; i++)
            {
                if(s[i] == c)
                {
                    found = i;
                    break;
                }
            }

            return found != -1 ? s.Substring(found + 1) : s;
        }

        public static string TakeAfter(this string s, string match)
        {
            var found = s.IndexOf(match);
            return found != -1 ? s.Substring(found + match.Length) : s;
        }
    }
}