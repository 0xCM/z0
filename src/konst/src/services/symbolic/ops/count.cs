//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;
    
    partial struct Symbolic   
    {   
        /// <summary>
        /// Counts the number of source characters that exist an a specified match set
        /// </summary>
        /// <param name="src"></param>
        /// <param name="match"></param>
        [MethodImpl(Inline), Op]
        public static int count(ReadOnlySpan<string> src, ReadOnlySpan<char> match)
        {
            var total = 0;
            var len = src.Length;
            for(var i=0u; i<len; i++)
                total += count(skip(src,i),match);
            return total;
        }

        [MethodImpl(Inline), Op]
        public static int count(ReadOnlySpan<char> src, ReadOnlySpan<char> match)
        {
            var total = 0u;
            for(var i=0u; i<src.Length; i++)
            {
                ref readonly var c = ref skip(src,i);
                for(var j=0u; j<match.Length; j++)
                    if(skip(match,j) == c)
                        total++;
            }

            return (int)total;
        }
    }
}