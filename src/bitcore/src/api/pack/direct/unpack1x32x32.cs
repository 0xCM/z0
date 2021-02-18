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
    using static cpu;

    partial struct BitPack
    {
        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x32(uint src, Span<uint> dst)
        {
            var buffer = z64;
            var w = w256;
            var n = n64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack1x8x8((byte)src, ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead);
            unpack1x8x8((byte)(src >> 8), ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead, 8);
            unpack1x8x8((byte)(src >> 16), ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead, 16);
            unpack1x8x8((byte)(src >> 24), ref tmp);
            vinflate8x256x32u(tmp).StoreTo(ref lead, 24);
        }

        [MethodImpl(Inline), Op]
        public static Span<uint> unpack1x32x32(uint src)
        {
            var buffer = MemoryStacks.alloc(w256);
            ref var tmp = ref MemoryStacks.head<byte>(ref buffer);

            var storage = MemoryStacks.alloc(w1024);
            ref var target = ref MemoryStacks.head<uint>(ref storage);

            unpack1x8x32(src, ref tmp);
            cpu.vinflate8x256x32u(tmp, 0, ref target);
            cpu.vinflate8x256x32u(tmp, 1, ref target);
            cpu.vinflate8x256x32u(tmp, 2, ref target);
            cpu.vinflate8x256x32u(tmp, 3, ref target);
            return MemoryStacks.span<uint>(ref storage);
        }
    }
}