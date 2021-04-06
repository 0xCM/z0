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
        /// Distributes each bit of the source to the hi bit of each byte a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vmask256x8u(uint src)
            => vconcat(vmask128x8u((ushort)src), vmask128x8u((ushort)(src >> 16)));

        [MethodImpl(Inline), Op]
        static ulong maskpart(uint src, int offset, ulong mask)
            => BitMasks.scatter((ulong)((byte)(src >> offset)), mask);
    }
}