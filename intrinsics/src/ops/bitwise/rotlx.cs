//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// Rotates the full 128 bits of a vector leftward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to rotate</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotlx(Vector128<ulong> src, int shift)
            => vor(vsllx(src, shift),vsrlx(src, 128 - shift));             

        /// <summary>
        /// Rotates each 128 lane leftward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to rotate</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotlx(Vector256<ulong> src, int shift)
            => vor(vsllx(src, shift),vsrlx(src, 128 - shift));             


    }

}