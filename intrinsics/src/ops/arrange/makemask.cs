//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class dinx
    {    
        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vmakemask(ushort src)
        {
            const ulong m = BitMasks.Msb64x8x1;
            var m0 = dinx.scatter((ulong)(byte)src, m);
            var m1 = dinx.scatter((ulong)((byte)(src >> 8)), m);
            return v8u(CpuVector.parts(n128,m0,m1));
        }

        /// <summary>
        /// Distributes each bit of the source to a specified bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The byte-relative bit position index in the range [0,7]</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vmakemask(ushort src, byte index)
        {
            var m = BitMasks.Lsb64x8x1 << index;
            var m0 = dinx.scatter((ulong)(byte)src, m);
            var m1 = dinx.scatter((ulong)((byte)(src >> 8)), m);
            return v8u(CpuVector.parts(n128,m0,m1));
        }

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vmakemask(uint src)
           => dinx.vconcat(vmakemask((ushort)src), vmakemask(((ushort)(src >> 16))));

        /// <summary>
        /// Distributes each bit of the source to to a specified bit of each byte in a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vmakemask(uint src, byte index)
           => dinx.vconcat(vmakemask((ushort)src, index), vmakemask(((ushort)(src >> 16)), index));

    }
}