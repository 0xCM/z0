//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        /// <summary>
        /// Computes the number of enabled source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static int pop(in BitSpan src)
        {
            var enabled = 0;
            var bitcount = src.Length;
            for(var i=0; i< bitcount; i++)
                enabled += (int)src[i];
            return enabled;
        }
    }
}