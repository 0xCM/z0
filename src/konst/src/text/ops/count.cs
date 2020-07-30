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

    partial class text
    {    
        [MethodImpl(Inline), Op]
        public static int count(ReadOnlySpan<string> src, int start)
        {
            var count = 0;
            for(var i=start; i<src.Length; i++)
            {
                ReadOnlySpan<char> data = skip(src,(uint)i);
                
                for(var j=0u; j<data.Length; j++)
                {
                    ref readonly var c = ref skip(data,j);
                    if(!text.whitespace(c))
                        count++;
                }
            }
            return count;
        }

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
                total += count(skip(src,i), match);
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
        
        [MethodImpl(Inline), Op]
        public static uint count(ReadOnlySpan<string> src, uint start, char exclude)
        {
            var count = 0u;
            
            for(var i=start; i<src.Length; i++)
            {
                ReadOnlySpan<char> data = skip(src,i);
                var len = data.Length;
                for(var j=0; j<len; j++)
                {
                    ref readonly var c = ref skip(data, j);
                    if(!whitespace(c) && c != exclude)
                        count++;
                }
            }
            return count;
        }
    }
}