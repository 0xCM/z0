//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    using static Memories;

    partial class BitPack
    {
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 8 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">A reference to the target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            refs.seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 16 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            refs.seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
            refs.seek64(ref unpacked, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 32 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint packed, ref byte unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            refs.seek64(ref unpacked, 0) = Bits.scatter((ulong)(byte)packed, m);
            refs.seek64(ref unpacked, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
            refs.seek64(ref unpacked, 2) = Bits.scatter((ulong)((byte)(packed >> 16)), m);
            refs.seek64(ref unpacked, 3) = Bits.scatter((ulong)((byte)(packed >> 24)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of 64 corresponding target bytes
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ulong packed, ref byte unpacked)        
        {
            unpack((uint)packed, ref unpacked);
            unpack((uint)(packed >> 32), ref seek(ref unpacked, 32));
        }
    }
}