//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class BitSpans
    {
        /// <summary>
        /// Replicates the content of a source bitspan into a new bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="count">The number of source copies to produce</param>
        [Op]
        public static BitSpan32 replicate(in BitSpan32 src, int count = 1)
        {
            Span<Bit32> data = new Bit32[src.Length * count];
            for(var i=0; i<count; i++)
                src.Data.CopyTo(data, i*src.Length);
            return load32(data);
        }
    }
}