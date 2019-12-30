//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial struct BitSpan
    {
        /// <summary>
        /// Replicates the content of a source bitspan into a target bitspan, repeatedly 
        /// or partially depending on the available space in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="count">The number of source copies to produce</param>
        public static ref readonly BitSpan replicate(in BitSpan src, in BitSpan dst)
        {
            if(src.Length == dst.Length)
                src.bits.CopyTo(dst.bits);
            else if (src.Length < dst.Length)
            {
                var q = dst.Length / src.Length;
                var r = dst.Length % src.Length;
                for(var i=0; i<q; i++)                
                    src.bits.CopyTo(dst.bits, i*src.Length);                
                src.bits.Slice(0,r).CopyTo(dst.bits, q*src.Length);
            }
            else
            {
                dst.bits.Clear();
                src.bits.Slice(0,dst.Length).CopyTo(dst.bits);
            }
            return ref dst;
        }

        /// <summary>
        /// Replicates the content of a source bitspan into a new bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="count">The number of source copies to produce</param>
        public static BitSpan replicate(in BitSpan src, int count = 1)
        {
            Span<bit> data = new bit[src.Length * count];
            for(var i=0; i<count; i++)
                src.bits.CopyTo(data, i*src.Length);
            return load(data);                
        }
    }

}