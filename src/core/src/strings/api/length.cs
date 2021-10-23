//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct strings
    {
        /// <summary>
        /// Computes the total length of the source strings
        /// </summary>
        /// <param name="src">The source strings</param>
        [MethodImpl(Inline), Op]
        public static uint length(ReadOnlySpan<string> src)
        {
            var counter = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                counter += (uint)s.Length;
            }
            return counter;
        }
    }
}