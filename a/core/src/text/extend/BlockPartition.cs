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

    using static Components;

    partial class XTend
    {
        /// <summary>
        /// Block-formats a string using specified block length and separator
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="blocklen">The number of characters in each block, save the last</param>
        /// <param name="sep">The block separator</param>
        [MethodImpl(Inline)]
        public static string BlockPartition(this string src, int blocklen, string sep)
            => src.Partition(blocklen).Concat(sep);

        /// <summary>
        /// Block-formats a string using specified block length and separator
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="blocklen">The number of characters in each block, save the last</param>
        /// <param name="sep">The block separator</param>
        [MethodImpl(Inline)]
        public static string BlockPartition(this string src, int blocklen, char sep)
            => src.Partition(blocklen).Concat(sep.ToString());

        /// <summary>
        /// Block-formats a string using specified block length, separator and block prefix
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="blocklen">The number of characters in each block, save the last</param>
        /// <param name="sep">The block separator</param>
        /// <param name="prefix">Content that immediately precedes each block</param>
        [MethodImpl(Inline)]
        public static string BlockPartition(this string src, int blocklen, char sep, string blockprefix)
        {
            var parts = src.Partition(blocklen).ToArray();            
            var result = new StringBuilder();
            var prefix = blockprefix ?? string.Empty;
            var lastindex = parts.Length - 1;
            for(var i=0; i<parts.Length; i++)
            {
                result.Append(prefix);
                result.Append(parts[i]);
                if(i != lastindex)
                    result.Append(sep);
            }
            return result.ToString();
        }    
    }
}