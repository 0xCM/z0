//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    
    partial class ginx
    {        
        /// <summary>
        /// Shifts the full 128 bits of a vector leftward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift</param>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.UnsignedInts)]
        public static Vector128<T> vsllx<T>(Vector128<T> src, [Imm] byte count)        
            where T : unmanaged
                => vgeneric<T>(dinx.vsllx(v64u(src), count));

        /// <summary>
        /// Shifts each 128 bit lane leftward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift</param>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.UnsignedInts)]
        public static Vector256<T> vsllx<T>(Vector256<T> src, [Imm] byte count)        
            where T : unmanaged
                => vgeneric<T>(dinx.vsllx(v64u(src), count));
    }
}