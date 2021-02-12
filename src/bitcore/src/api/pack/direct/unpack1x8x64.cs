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
        [MethodImpl(Inline), Op]
        public static void unpack1x8x64(ulong src, Span<uint> dst)
        {
            var buffer = MemoryStacks.alloc(w512);
            ref var tmp = ref first(slice(dst,56,8).Recover<uint,byte>());
            ref var target = ref first(dst);

            unpack1x8x32((uint)src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target, 0);
            vinflate8x256x32u(tmp, 1, ref target, 1);
            vinflate8x256x32u(tmp, 2, ref target, 2);
            vinflate8x256x32u(tmp, 3, ref target, 3);

            unpack1x8x32((uint)(src >> 32), ref tmp);
            vinflate8x256x32u(tmp, 0, ref target, 4);
            vinflate8x256x32u(tmp, 1, ref target, 5);
            vinflate8x256x32u(tmp, 2, ref target, 6);
            vinflate8x256x32u(tmp, 3, ref target, 7);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 64 corresponding target bytes
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref byte unpack1x8x64(ulong src, ref byte dst)
        {
            unpack1x8x32((uint)src, ref dst);
            unpack1x8x32((uint)(src >> 32), ref seek(dst, 32));
            return ref dst;
        }

        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack1x8x64(ulong src, ref ulong dst)
        {
            unpack1x8x32((uint)src, ref dst);
            unpack1x8x32((uint)(src >> 32), ref seek8(dst, 32));
            return ref dst;
        }

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline), Unpack]
        public static void unpack1x8x64(ulong src, Span<byte> dst)
            => unpack1x8x64(src, ref first64(dst));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly SpanBlock512<byte> unpack1x8x64(ulong src, in SpanBlock512<byte> dst, int block)
        {
            unpack1x8x64(src, dst.Block(block));
            return ref dst;
        }
    }
}