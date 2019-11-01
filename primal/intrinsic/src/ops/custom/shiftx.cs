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
        /// Shifts the entire 128-bit vector leftwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits the shift leftward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsllx(Vector128<ulong> src, byte offset)        
        {
            if(offset >= 64)
                return vsll(vbsll(src, 8), (byte)(offset - 64));     
            else
            {           
                var x = vbsll(src, 8);
                var y = vsll(src, offset);
                return vor(y, vsrl(x, (byte)(64 - offset)));
            }
        }

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
        /// Rotates the full 128 bits of a vector rightward a bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to rotate</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotrx(Vector128<ulong> src, byte offset)
        {
            const byte seglen = 128;
            var x = vsrlx(src, offset);
            var y = vsllx(src, (byte)(seglen - offset));   
            return vor(x,y);             
        }


    }

}