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
    
    partial class ginx
    {
        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vmakemask<T>(ushort src)
            where T : unmanaged
                => vgeneric<T>(v8u(dinx.vmakemask(src)));

        /// <summary>
        /// Distributes each bit of the source to a specified bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The byte-relative bit position index in the range [0,7]</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vmakemask<T>(ushort src, byte index)
            where T : unmanaged
                => vgeneric<T>(v8u(dinx.vmakemask(src, index)));

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vmakemask<T>(uint src)
            where T : unmanaged
                => vgeneric<T>(v8u(dinx.vmakemask(src)));

        /// <summary>
        /// Distributes each bit of the source to a specified bit of each byte in a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The byte-relative bit position index in the range [0,7]</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vmakemask<T>(uint src, byte index)
            where T : unmanaged
                => vgeneric<T>(v8u(dinx.vmakemask(src,index)));

    }
}