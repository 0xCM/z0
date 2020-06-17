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
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<byte> dst)
        {
            var mask = BitMask.lsb<ulong>(n8,n1);
            ref var lead = ref head(dst);
            
            refs.seek64(ref lead, 0) = Bits.scatter((ulong)(byte)src, mask);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(ushort src, Span<byte> dst)
        {
            var mask = BitMask.lsb<ulong>(n8,n1);
            ref var lead = ref head(dst);
            
            refs.seek64(ref lead, 0) = Bits.scatter((ulong)(byte)src, mask);
            refs.seek64(ref lead, 1) = Bits.scatter((ulong)((byte)(src >> 8)), mask);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(uint src, Span<byte> dst)
        {
            var mask = BitMask.lsb<ulong>(n8,n1);
            ref var lead = ref head(dst);

            refs.seek64(ref lead, 0) = Bits.scatter((ulong)(byte)src, mask);
            refs.seek64(ref lead, 1) = Bits.scatter((ulong)((byte)(src >> 8)), mask);
            refs.seek64(ref lead, 2) = Bits.scatter((ulong)((byte)(src >> 16)), mask);
            refs.seek64(ref lead, 3) = Bits.scatter((ulong)((byte)(src >> 24)), mask);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack(ulong src, Span<byte> dst)
        {
            unpack((uint)src, dst.Slice(0,32));
            unpack((uint)(src >> 32), dst.Slice(32,32));
        }
        
  }
}