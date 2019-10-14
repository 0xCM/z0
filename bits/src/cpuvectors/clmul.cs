//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// Defines a reference implementation of caryless multiplication that follows
        /// Intel's published algirithm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        public static BitVector128 clmul_ref(BitVector64 x, BitVector64 y)
        {
            var temp1 = x;
            var temp2 = y;

            var dst = BitVector128.Zero;            
            var tmp = BitVector128.Zero;

            for(var i=0; i<64; i++)
            {
                tmp[i] = temp1[0] & temp2[i];
                for(var j = 1; j <=i; j++)
                    tmp[i] = tmp[i] ^ (temp1[j] & temp2[i - j]);
                dst[i] = tmp[i];
            }

            for(var i=64; i<128; i++)
            {
                tmp[i] = false;
                for(var j=(i - 63); j< 64; j++)
                    tmp[i] = tmp[i] ^(temp1[j] & temp2[i-j]);
                dst[i] = tmp[i];
            }
            dst[127] = false;
            
            return dst;
        }


    }
}