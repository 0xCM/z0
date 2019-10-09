//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        
        const byte M70 = 0b01110000;

        const byte MF0 = 0b11110000;

        static readonly Vec256<byte> K0 = Vec256.FromBytes(
            M70, M70, M70, M70, M70, M70, M70, M70, 
            M70, M70, M70, M70, M70, M70, M70, M70,            
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0);

        static readonly Vec256<byte> K1 = Vec256.FromBytes(
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0,            
            M70, M70, M70, M70, M70, M70, M70, M70, 
            M70, M70, M70, M70, M70, M70, M70, M70);            

        /// <summary>
        /// Rearranges the source vector according to the indices specified in the control vector
        /// dst[i] = src[spec[i]]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector that defines the permutation</param>
        /// <remarks>Approach follows https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector/30669632#30669632</remarks>
        public static Vec256<byte> vperm32x8(in Vec256<byte> src, in Vec256<byte> spec)
        {
            var a = src;
            var b = swaphl(in src);
            var s1 = shuffle(in a, vadd(in spec, in K0));
            var s2 = shuffle(in b, vadd(in spec, in K1));
            return vor(s1,s2);
        }
 
    }
}