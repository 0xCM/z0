//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {

        /// <summary>
        /// Shifts the entire 128-bit vector leftwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits the shift leftward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vsllx(in Vec128<ulong> src, byte offset)        
        {
            var x = dinx.vbsll(src, 8);
            var y = dinx.vsll(src, offset);
            x = dinx.vsrl(x, (byte)(64 - offset));
            return dinx.vor(y,x);
        }

        /// <summary>
        /// Shifts the entire 128-bit vector rightwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits the shift rightward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vslrx(in Vec128<ulong> src, byte offset)        
        {
            var x = dinx.vbsrl(src, 8);
            var y = dinx.vsrl(src, offset);
            x = dinx.vsll(x, (byte)(64 - offset));
            return dinx.vor(y,x);
        }
    }
}