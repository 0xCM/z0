//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;

    partial class BitPack
    {
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8(byte packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8(ushort packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);
            seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
            seek64(ref dst, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8(uint packed, Span<byte> unpacked)
        {
            var m = BitMask.lsb<ulong>(n8,n1);
            ref var dst = ref head(unpacked);

            seek64(ref dst, 0) = Bits.scatter((ulong)(byte)packed, m);
            seek64(ref dst, 1) = Bits.scatter((ulong)((byte)(packed >> 8)), m);
            seek64(ref dst, 2) = Bits.scatter((ulong)((byte)(packed >> 16)), m);
            seek64(ref dst, 3) = Bits.scatter((ulong)((byte)(packed >> 24)), m);
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The target buffer</param>
        [MethodImpl(Inline)]
        public static void unpack8(ulong packed, Span<byte> unpacked)        
        {
            unpack8((uint)packed, unpacked.Slice(0,32));
            unpack8((uint)(packed >> 32), unpacked.Slice(32,32));
        }



    }

}