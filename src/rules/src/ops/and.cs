//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial struct RuleModels
    {
        [Op]
        public static ReadOnlySpan<string> apply(SeqSplit<char> rule, string src)
        {
            var output = list<string>();
            var len = src?.Length ?? 0;
            var buffer = span<char>(len);
            var input = span(src);
            var j = 0;
            for(var i=0; i<len; i++)
            {
                ref readonly var c = ref skip(input,i);
                if(c == rule.Delimiter)
                {
                    if(j != 0)
                    {
                        output.Add(new string(slice(buffer, 0, j)));
                        buffer.Clear();
                        j=0;
                    }
                }
                else
                    seek(buffer,j++) = c;
            }

            if(j != 0)
                output.Add(new string(slice(buffer, 0, j)));

            return output.ViewDeposited();
        }


        /// <summary>
        /// Creates a hashset from an input sequence
        /// </summary>
        /// <param name="rule">The rule specification</param>
        /// <param name="src">The input sequence</param>
        [Op]
        public static HashSet<string> apply(Distinct<string> rule, ReadOnlySpan<string> src)
        {
            var count = src.Length;
            var dst = hashset<string>(count);
            for(var i=0; i<count; i++)
                dst.Add(skip(src,i));
            return dst;
        }
    }
}