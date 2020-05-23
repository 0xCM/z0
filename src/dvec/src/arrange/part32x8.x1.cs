//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Vectors;
    using static Typed;
    using static As;

    partial class dvec
    {            
        /// <summary>
        /// Partitions a 32-bit source value into 32 8-bit peices each with an effective width of q
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vpart32x8x1(uint src)
        {
            var x = vbroadcast(n256, src);
            var y = vbroadcast(n256,BitMasks.Msb32x8x7);
            return v8u(dvec.vand(x,y));
        }
    }
}