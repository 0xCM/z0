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
        /// Distributes each bit of the source to the hi bit of each 8-bit segment in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vmakemask<T>(ushort src)
            where T : unmanaged
                => vgeneric<T>(v8u(dinx.vmakemask(src)));

        /// <summary>
        /// Distributes each bit of the source to the hi bit of each 8-bit segment in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vmakemask<T>(uint src)
            where T : unmanaged
                => vgeneric<T>(v8u(dinx.vmakemask(src)));

    }
}