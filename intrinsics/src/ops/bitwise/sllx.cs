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
        /// <param name="shift">The number of bits the shift leftward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsllx(Vector128<ulong> src, byte shift)        
        {
            if(shift >= 64)
                return vsll(vbsll(src, 8), shift - 64);     
            else
            {           
                var x = vbsll(src, 8);
                var y = vsll(src, shift);
                return vor(y, vsrl(x, 64 - shift));
            }
        }

        [MethodImpl(Inline)]
        public static Vector128<byte> vsllx(Vector128<byte> src, byte shift)        
            => v8u(vsllx(v64u(src), shift));
        
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsllx(Vector128<ushort> src, byte shift)        
            => v16u(vsllx(v64u(src), shift));

        [MethodImpl(Inline)]
        public static Vector128<uint> vsllx(Vector128<uint> src, byte shift)        
            => v32u(vsllx(v64u(src), shift));

        /// <summary>
        /// Shifts each 128-bit lane leftwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits the shift leftward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsllx(Vector256<ulong> src, byte shift)        
        {
            if(shift >= 64)
                return vsll(vbsll(src, 8), shift - 64);     
            else
            {           
                var x = vbsll(src, 8);
                var y = vsll(src, shift);
                return vor(y, vsrl(x, 64 - shift));
            }
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> vsllx(Vector256<byte> src, byte shift)        
            => v8u(vsllx(v64u(src), shift));
        
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsllx(Vector256<ushort> src, byte shift)        
            => v16u(vsllx(v64u(src), shift));

        [MethodImpl(Inline)]
        public static Vector256<uint> vsllx(Vector256<uint> src, byte shift)        
            => v32u(vsllx(v64u(src), shift));

    }

}