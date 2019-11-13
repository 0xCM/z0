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
        /// Shifts the entire 128-bit vector rightwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift rightward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlx(Vector128<ulong> src, byte offset)        
        {
            if(offset >= 64)
                return vsrl(vbsrl(src, 8), (byte)(offset - 64));     
            else
            {
                var x = vbsrl(src, 8);
                var y = vsrl(src, offset);
                return vor(y, vsll(x, (byte)(64 - offset)));
            }
        }

        /// <summary>
        /// Shifts each 128-bit lane rightwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift rightward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrlx(Vector256<ulong> src, byte offset)        
        {
            if(offset >= 64)
                return vsrl(vbsrl(src, 8), (byte)(offset - 64));     
            else
            {
                var x = vbsrl(src, 8);
                var y = vsrl(src, offset);
                return vor(y, vsll(x, (byte)(64 - offset)));
            }
        }
    }
}