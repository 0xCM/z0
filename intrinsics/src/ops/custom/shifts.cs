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

        [MethodImpl(Inline)]
        public static Vector128<byte> vsll(Vector128<byte> src, byte offset)
        {
            // Lift the source vector into a space where the SLL operation exists and perform it there
            var srcX = vconvert(src, out Vector256<ushort> _);
            var dstA = v8u(dinx.vsll(srcX, offset));

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0]
            var trm =  ginx.valtclear<byte>(n256);
            var trA = dinx.vshuf16x8(dstA, trm);

            // Transform the result back the source space
            var permSpec = ginx.vlanemerge<byte>();
            var permA = dinx.vshuf32x8(trA, permSpec);
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
            var trm =  ginx.valtclear<byte>(n256);
            var trA = dinx.vshuf16x8(dstA, trm);
            var trB = dinx.vshuf16x8(dstB, trm);

            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            var permSpec = ginx.vlanemerge<byte>();
            var permA = dinx.vshuf32x8(trA, permSpec);
            var permB = dinx.vshuf32x8(trB, permSpec);
            
            return dinx.vinsert(dinx.vlo(permA), dinx.vlo(permB), out Vector256<byte> _);            
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
            var trm = ginx.valtclear<byte>(n256);
            var trA = dinx.vshuf16x8(dstA, trm);
            var trB = dinx.vshuf16x8(dstB, trm);
                        
            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            var permSpec = ginx.vlanemerge<byte>();
            var permA = dinx.vshuf32x8(trA, permSpec);
            var permB = dinx.vshuf32x8(trB, permSpec);
            return dinx.vinsert(dinx.vlo(permA), dinx.vlo(permB), out Vector256<byte> _);            
        } 

        [MethodImpl(Inline)]
        public static Vector128<byte> vsrl(Vector128<byte> src, byte offset)
        {
            // Lift the source vector into a space where the SRL operation exists and perform it there
            var srcX = vconvert(src, out Vector256<ushort> _);
            var dstA = dinx.vsrl(srcX, offset).AsByte();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0]
            var trm =  ginx.valtclear<byte>(n256);
            var trA = dinx.vshuf16x8(dstA, trm);

            // Transform the result back the source space
            var permSpec = ginx.vlanemerge<byte>();
            var permA = dinx.vshuf32x8(trA, permSpec);
            return dinx.vlo(permA);
        }

    }

}