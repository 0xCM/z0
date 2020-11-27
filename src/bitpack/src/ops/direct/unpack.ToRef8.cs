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
        /// Distributes each packed source bit to the least significant bit of 8 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">A reference to the target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack8(byte packed, ref byte unpacked)
            => seek64(unpacked, 0) = scatter((ulong)(byte)packed, lsb<ulong>(n8,n1));

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 16 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack16(ushort packed, ref byte unpacked)
        {
            var m = lsb<ulong>(n8, n1);
            seek64(unpacked, 0) = scatter((ulong)(byte)packed, m);
            seek64(unpacked, 1) = scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 32 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack32(uint packed, ref byte unpacked)
        {
            var m = lsb<ulong>(n8,n1);
            seek64(unpacked, 0) = scatter((ulong)(byte)packed, m);
            seek64(unpacked, 1) = scatter((ulong)((byte)(packed >> 8)), m);
            seek64(unpacked, 2) = scatter((ulong)((byte)(packed >> 16)), m);
            seek64(unpacked, 3) = scatter((ulong)((byte)(packed >> 24)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 64 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack64(ulong packed, ref byte unpacked)
        {
            unpack32((uint)packed, ref unpacked);
            unpack32((uint)(packed >> 32), ref seek(unpacked, 32));
        }
    }
}