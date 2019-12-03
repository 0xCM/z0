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
        /// <param name="shift">The number of bits to shift rightward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlx(Vector128<ulong> src, int shift)        
        {
            if(shift >= 64)
                return vsrl(vbsrl(src, 8), shift - 64);     
            else
            {
                var x = vbsrl(src, 8);
                var y = vsrl(src, shift);
                return vor(y, vsll(x, 64 - shift));
            }
        }

        [MethodImpl(Inline)]
        public static Vector128<byte> vsrlx(Vector128<byte> src, int shift)        
            => v8u(vsrlx(v64u(src), shift));
        
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsrlx(Vector128<ushort> src, int shift)        
            => v16u(vsrlx(v64u(src), shift));

        [MethodImpl(Inline)]
        public static Vector128<uint> vsrlx(Vector128<uint> src, int shift)        
            => v32u(vsrlx(v64u(src), shift));

        /// <summary>
        /// Shifts each 128-bit lane rightwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift rightward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrlx(Vector256<ulong> src, int shift)        
        {
            if(shift >= 64)
                return vsrl(vbsrl(src, 8), shift - 64);     
            else
            {
                var x = vbsrl(src, 8);
                var y = vsrl(src, shift);
                return vor(y, vsll(x, 64 - shift));
            }
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> vsrlx(Vector256<byte> src, int shift)        
            => v8u(vsrlx(v64u(src), shift));
        
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrlx(Vector256<ushort> src, int shift)        
            => v16u(vsrlx(v64u(src), shift));

        [MethodImpl(Inline)]
        public static Vector256<uint> vsrlx(Vector256<uint> src, int shift)        
            => v32u(vsrlx(v64u(src), shift));
    }
}