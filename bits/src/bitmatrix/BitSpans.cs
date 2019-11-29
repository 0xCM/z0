//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public static partial class BitRng
    {

        /// <summary>
        /// Populates a caller-supplied target with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        public static void Fill(this IPolyrand random, Span<bit> dst)
        {
            const int segwidth = 64;
            var count = dst.Length;
            var segcount = count / segwidth;
            var remcount = count % segwidth;
            var part = 0;
            
            for(var i=0; i < segcount; i++)
            {
                ref var dsthead = ref head(dst.Slice(part));
                ref readonly var seq = ref head(BitStore.bitseq(random.Next<ulong>())); 
                for(var j=0; j<segwidth; j++)           
                    seek(ref dsthead, j) = (bit)skip(in seq, j);
                part += segwidth;
            }

            ref var remdst = ref head(dst.Slice(part));
            ref readonly var remsrc = ref head(BitStore.bitseq(random.Next<ulong>())); 
            for(var i=0; i< remcount; i++)
                seek(ref remdst, i) = (bit)skip(in remsrc, i);
            
        }
    }

}