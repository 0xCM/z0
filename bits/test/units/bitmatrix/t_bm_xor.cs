//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_xor : BitMatrixTest<t_bm_xor>
    {        
        public void xor_8x8g()
            => xor_generic_check<byte>();

        public void xor_16x16g()
            => xor_generic_check<ushort>();

        public void xor_32x32g()
            => xor_generic_check<uint>();

        public void xor_64x64g()
            => xor_generic_check<ulong>();

       void xor_generic_check<T>()
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<T>();
                var B = Random.BitMatrix<T>();
                BitMatrix.xor(A,B, ref Z);

                for(var j =0; j< Z.Order; j++)
                {
                    var a = A[i];
                    var b = B[i];                    
                    var z = Z[i];

                    var x = BitVector.xor(a,b);
                    Claim.yea(x == z);
                }
            }
        }
 

    }

}