//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class gbits
    {
        /// <summary>
        /// Maps a sequence of lower source bits over a target segment
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The target</param>
        /// <param name="start">The target-relative index at which to begin the overwrite</param>
        /// <param name="length">The number bits to read from the source an replace in the target</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T bitmap<T>(T src, T dst, byte start, byte length)
            where T : unmanaged
        {
            var dstPrep = bitclear(dst,start,length);
            var srcPrep = gmath.sll(gmath.and(BitMask.lo<T>(length), src), start);
            return gmath.or(dstPrep, srcPrep);
        }                
    }
}