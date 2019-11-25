//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_gbm_xor : BitMatrixTest<t_gbm_xor>
    {        
        public void gbm_xor_8()
            => gbm_xor_check<byte>();

        public void gbm_xor_16()
            => gbm_xor_check<ushort>();

        public void gbm_xor_32()
            => gbm_xor_check<uint>();

        public void gbm_xor_64()
            => gbm_xor_check<ulong>();

       protected void gbm_xor_check<T>()
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