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
        /// Distributes each bit of the source to a specified bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The byte-relative bit position index in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<byte> vmask128(ushort src, byte index)
            => vinflate128x8u(src, index);

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vmask128x8u(ushort src)
            => v8u(vparts(maskpart(src,0), maskpart(src,8)));

        [MethodImpl(Inline), Op]
        static ulong maskpart(uint src, int offset)
            => BitMasks.scatter((ulong)((byte)(src >> offset)), Msb64x8x1);
    }
}