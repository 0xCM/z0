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
    using static BitMasks.Literals;

    partial struct cpu
    {
        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vmask256(uint src)
            => cpu.vconcat(vmask128((ushort)src), vmask128((ushort)(src >> 16)));

        /// <summary>
        /// Distributes each bit of the source to to a specified bit of each byte in a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vmask256(uint src, byte index)
        {
            var m = Lsb64x8x1 << index;
            var lo = v8u(cpu.vparts(maskpart(src, 0, m), maskpart(src, 8, m)));
            var hi = v8u(cpu.vparts(maskpart(src, 16, m), maskpart(src, 24, m)));
            return cpu.vconcat(lo,hi);
        }
    }
}