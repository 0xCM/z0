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
    using static AsIn;
    
    partial class dinx
    {    

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vmakemask(ushort src)
        {
            var m0 = dinx.scatter((ulong)(byte)src, BitMask.Msb64x8);
            var m1 = dinx.scatter((ulong)((byte)(src >> 8)), BitMask.Msb64x8);
            return v8u(dinx.vparts(n128,m0,m1));
        }

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vmakemask(uint src)
            => dinx.vconcat(vmakemask((ushort)src), vmakemask(((ushort)(src >> 16))));

    }
}