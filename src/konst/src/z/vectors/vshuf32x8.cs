//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
        
    using static Konst; 
    using static z;

    partial struct z
    {        
        /// <summary>
        /// Rearranges the source vector according to the indices specified in the control vector dst[i] = src[spec[i]]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector that defines the permutation</param>
        /// <remarks>Approach follows https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector/30669632#30669632</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vshuf32x8(Vector256<byte> a, Vector256<byte> spec)
        {            
            var x = z.vshuf16x8(a, z.vadd(spec, K0V));
            var y = z.vshuf16x8(z.vswaphl(a), z.vadd(spec, K1V));
            return z.vor(x,y);
        }

        const byte M70 = 0b01110000;

        const byte MF0 = 0b11110000;

        static Vector256<byte> K0V 
        {
            [MethodImpl(Inline)]
            get => vload(n256, K0Bytes);
        }

        static Vector256<byte> K1V 
        {
            [MethodImpl(Inline)]
            get => vload(n256,K1Bytes);
        }

        static ReadOnlySpan<byte> K0Bytes
            => new byte[]
                {
                    M70, M70, M70, M70, M70, M70, M70, M70, 
                    M70, M70, M70, M70, M70, M70, M70, M70,            
                    MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
                    MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0
                };

        static ReadOnlySpan<byte> K1Bytes
            => new byte[]
                {
                    MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
                    MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0,            
                    M70, M70, M70, M70, M70, M70, M70, M70, 
                    M70, M70, M70, M70, M70, M70, M70, M70
                };
    }
}