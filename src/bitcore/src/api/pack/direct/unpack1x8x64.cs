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
    using static BitMasks;
    using static BitMasks.Literals;

    partial struct BitPack
    {
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock128<byte> unpack1x8x16(ushort src, in SpanBlock128<byte> dst, int block)
        {
            unpack(src, dst.Block(block));
            return ref dst;
        }
    }
}