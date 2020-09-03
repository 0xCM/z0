//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static V0;
    using static V0d;

    partial class dvec
    {
        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vmakemask(ushort src)
            => v8u(vparts(maskpart(src,0), maskpart(src,8)));

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vmakemask(uint src)
            => vconcat(vmakemask((ushort)src), vmakemask((ushort)(src >> 16)));

        /// <summary>
        /// Distributes each source bit to an index-identified bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The bit position index, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vmakemask(ushort src, byte index)
        {
            var m = MaskLiterals.Lsb64x8x1 << index;
            return v8u(vparts(maskpart(src,0, m), maskpart(src,8, m)));
        }

        /// <summary>
        /// Distributes each bit of the source to to a specified bit of each byte in a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vmakemask(uint src, byte index)
        {
            var m = MaskLiterals.Lsb64x8x1 << index;
            var lo = v8u(vparts(maskpart(src, 0, m), maskpart(src, 8, m)));
            var hi = v8u(vparts(maskpart(src, 16, m), maskpart(src, 24, m)));
            return vconcat(lo,hi);
        }

        [MethodImpl(Inline), Op]
        static ulong maskpart(uint src, int offset)
            => Bits.scatter((ulong)((byte)(src >> offset)), MaskLiterals.Msb64x8x1);

        [MethodImpl(Inline), Op]
        static ulong maskpart(uint src, int offset, ulong mask)
            => Bits.scatter((ulong)((byte)(src >> offset)), mask);
    }
}