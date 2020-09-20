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
    using static z;

    partial class gvec
    {
        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> vmakemask<T>(ushort src)
            where T : unmanaged
                => generic<T>(z.v8u(dvec.vmakemask(src)));

        /// <summary>
        /// Distributes each bit of the source to a specified bit of each byte in a 128-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The byte-relative bit position index in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> vmakemask<T>(ushort src, byte index)
            where T : unmanaged
                => generic<T>(v8u(dvec.vmakemask(src, index)));

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each byte a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vmakemask<T>(uint src)
            where T : unmanaged
                => generic<T>(v8u(dvec.vmakemask(src)));

        /// <summary>
        /// Distributes each bit of the source to a specified bit of each byte in a 256-bit target vector
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The byte-relative bit position index in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vmakemask<T>(uint src, byte index)
            where T : unmanaged
                => generic<T>(v8u(dvec.vmakemask(src,index)));
    }
}