//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static BitMasks;

    partial class BitPack
    {
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<byte> dst)
            => seek64(first(dst), 0) = scatter((ulong)(byte)src, lsb<ulong>(n8,n1));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort src, Span<byte> dst)
        {
            var mask = lsb<ulong>(n8, n1);
            ref var lead = ref first(dst);
            seek64(lead, 0) = scatter((ulong)(byte)src, mask);
            seek64(lead, 1) = scatter((ulong)((byte)(src >> 8)), mask);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint src, Span<byte> dst)
        {
            var mask = lsb<ulong>(n8,n1);
            ref var lead = ref first(dst);
            seek64(lead, 0) = scatter((ulong)(byte)src, mask);
            seek64(lead, 1) = scatter((ulong)((byte)(src >> 8)), mask);
            seek64(lead, 2) = scatter((ulong)((byte)(src >> 16)), mask);
            seek64(lead, 3) = scatter((ulong)((byte)(src >> 24)), mask);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ulong src, Span<byte> dst)
        {
            unpack((uint)src, slice(dst, 0, 32));
            unpack((uint)(src >> 32), slice(dst, 32, 32));
        }
    }
}