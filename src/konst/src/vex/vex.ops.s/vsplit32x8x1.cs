//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// Partitions a 32-bit source value into 32 8-bit pieces each with an effective width of 1
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsplit32x8x1(uint src)
        {
            var x = cpu.vbroadcast(w256, src);
            var y = cpu.vbroadcast(w256, BitMasks.Literals.Msb32x8x7);
            return v8u(vand(x,y));
        }
    }
}