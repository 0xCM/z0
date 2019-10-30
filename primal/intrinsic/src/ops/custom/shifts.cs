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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;
    using static dinx;

    partial class dinxc
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
            var x = dinx.vbsll(src, 8);
            var y = dinx.vsll(src, offset);
            return dinx.vor(y, dinx.vsrl(x, (byte)(64 - offset)));
        }

        [MethodImpl(Inline)]
        public static Vector128<byte> vsll(Vector128<byte> src, byte offset)
        {
            // Lift the source vector into a space where the SLL operation exists and perform it there
            var srcX = vconvert(src, out Vector256<ushort> _);
            var dstA = dinx.vsll(srcX, offset).AsByte();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0]
            var trm =  Vec256Pattern.ClearAltVector<byte>();
            var trA = dinx.vshuffle(dstA, trm);

            // Transform the result back the source space
            var permSpec = ginx.vpLaneMerge<byte>();
            var permA = dinx.vpermvar32x8(trA, permSpec);
            return dinx.vlo(permA);
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> vsll(Vector256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            var srcX = vconvert(dinx.vlo(src), out Vector256<ushort> _);
            var srcY = vconvert(dinx.vhi(src), out Vector256<ushort> _);

            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = dinx.vsll(srcX, offset).AsByte();
            var dstB = dinx.vsll(srcY, offset).AsByte();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0] in each vector
            var trm =  Vec256Pattern.ClearAltVector<byte>();
            var trA = dinx.vshuffle(dstA, trm);
            var trB = dinx.vshuffle(dstB, trm);

            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            var permSpec = ginx.vpLaneMerge<byte>();
            var permA = dinx.vpermvar32x8(trA, permSpec);
            var permB = dinx.vpermvar32x8(trB, permSpec);
            
            return dinx.vinsert(dinx.vlo(permA), dinx.vlo(permB), out Vector256<byte> _);            
        }

        /// <summary>
        /// Shifts the entire 128-bit vector rightwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits the shift rightward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlx(Vector128<ulong> src, byte offset)        
        {
            var x = dinx.vbsrl(src, 8);
            var y = dinx.vsrl(src, offset);
            return dinx.vor(y,dinx.vsll(x, (byte)(64 - offset)));
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> vsrl(Vector256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            var srcX = vconvert(dinx.vlo(src), out Vector256<ushort> _);
            var srcY = vconvert(dinx.vhi(src), out Vector256<ushort> _);
            
            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = dinx.vsrl(srcX, offset).AsByte();
            var dstB = dinx.vsrl(srcY, offset).AsByte();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0] in each vector
            var trm = Vec256Pattern.ClearAltVector<byte>();
            var trA = dinx.vshuffle(dstA, trm);
            var trB = dinx.vshuffle(dstB, trm);
                        
            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            var permSpec = ginx.vpLaneMerge<byte>();
            var permA = dinx.vpermvar32x8(trA, permSpec);
            var permB = dinx.vpermvar32x8(trB, permSpec);
            return dinx.vinsert(dinx.vlo(permA), dinx.vlo(permB), out Vector256<byte> _);            
        } 

        [MethodImpl(Inline)]
        public static Vector128<byte> vsrl(Vector128<byte> src, byte offset)
        {
            // Lift the source vector into a space where the SRL operation exists and perform it there
            var srcX = vconvert(src, out Vector256<ushort> _);
            var dstA = dinx.vsrl(srcX, offset).AsByte();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0]
            var trm =  Vec256Pattern.ClearAltVector<byte>();
            var trA = dinx.vshuffle(dstA, trm);

            // Transform the result back the source space
            var permSpec = ginx.vpLaneMerge<byte>();
            var permA = dinx.vpermvar32x8(trA, permSpec);
            return dinx.vlo(permA);
        }

    }

}