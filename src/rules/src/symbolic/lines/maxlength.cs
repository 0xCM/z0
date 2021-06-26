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

    using SQ = SymbolicQuery;

    partial struct Lines
    {
        /// <summary>
        /// Computes the maximum line length of the lines represented by asci-encoded bytes
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static uint maxlength(ReadOnlySpan<byte> src)
        {
            var size = src.Length;
            var max = 0u;
            var current = 0u;
            for(var pos=0u; pos<size; pos++)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(!SQ.eol(a0,a1))
                    current++;
                else
                {
                    if(current > max)
                        max = current;
                    current = 0;
                    pos++;
                }
            }
            return max;
        }

        [MethodImpl(Inline), Op]
        public static uint maxlength(ReadOnlySpan<char> src)
        {
            var size = src.Length;
            var max = 0u;
            var current = 0u;
            for(var pos=0u; pos<size; pos++)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(!SQ.eol(a0,a1))
                    current++;
                else
                {
                    if(current > max)
                        max = current;
                    current = 0;
                    pos++;
                }
            }
            return max;
        }
    }
}