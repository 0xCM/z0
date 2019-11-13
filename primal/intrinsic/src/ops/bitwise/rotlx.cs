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
        /// <param name="offset">The number of bits to rotate</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotlx(Vector128<ulong> src, byte offset)
        {
            const byte seglen = 128;
            var x = vsllx(src, offset);
            var y = vsrlx(src, (byte)(seglen - offset));   
            return vor(x,y);             
        }

        /// <summary>
        /// Rotates each 128 lane leftward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to rotate</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotlx(Vector256<ulong> src, byte offset)
        {
            const byte seglen = 128;
            var x = vsllx(src, offset);
            var y = vsrlx(src, (byte)(seglen - offset));   
            return vor(x,y);             
        }


    }

}