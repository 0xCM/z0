//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Bits
    {
        /// <summary>
        /// Packs the least significant bit from 32 32-bit unsigned integers to a 32-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref uint pack32x32x1(in uint src, ref uint dst)
        {
            var v0 = cpu.vload(w256, skip(src,0*8));
            var v1 = cpu.vload(w256, skip(src,1*8));
            var x = cpu.vpack256x16u(v0, v1, w256);

            v0 = cpu.vload(w256, skip(src,2*8));
            v1 = cpu.vload(w256, skip(src,3*8));
            var y = cpu.vpack256x16u(v0,v1, w256);

            dst = gcpu.vpacklsb(cpu.vpack256x8u(x, y, w256));
            return ref dst;
        }

        /// <summary>
        /// Packs the least significant bit from <see cref='n32'/> <see cref='w32'/> <see cref='uint'/> source values to a <see cref='w32'/> bit <see cref='uint'/> target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref uint pack32x32x1(in NatSpan<N32,uint> src, ref uint dst)
        {
            dst = pack32x32x1(src.First, ref dst);
            return ref dst;
        }

    }
}