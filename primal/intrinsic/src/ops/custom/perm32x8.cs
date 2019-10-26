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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        
        /// <summary>
        /// Rearranges the source vector according to the indices specified in the control vector
        /// dst[i] = src[spec[i]]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector that defines the permutation</param>
        /// <remarks>Approach follows https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector/30669632#30669632</remarks>
        [MethodImpl(Inline)]
        public static Vector256<byte> vpermvar32x8(Vector256<byte> a, Vector256<byte> spec)
        {            
            var x = vshuffle(a, vadd(spec, K0V));
            var y = vshuffle(vswaphl(a), vadd(spec, K1V));
            return vor(x,y);
        }

        const byte M70 = 0b01110000;

        const byte MF0 = 0b11110000;

        static Vector256<byte> K0V 
        {
            [MethodImpl(Inline)]
            get => dinx.vloadu(in head(K0Bytes), out Vector256<byte> _);
        }

        static Vector256<byte> K1V 
        {
            [MethodImpl(Inline)]
            get => dinx.vloadu(in head(K1Bytes), out Vector256<byte> _);
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