//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
 
    partial struct BitSpan
    {
        /// <summary>
        /// Clamps the source bitstring to one of a specified maximum length, discarding any excess
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="maxbits">The maximum length of the target bitstring</param>
        [MethodImpl(Inline)]
        public static BitSpan truncate(in BitSpan src, int maxbits)
            => src.Length <= maxbits ? src : new BitSpan(src.bits.Slice(0, maxbits));
    }
}