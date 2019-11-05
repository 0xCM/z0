//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_bitlogic : BitMatrixTest<t_bm_bitlogic>
    {

        
        public void bmxor_generic_check_8x8()
            => bmxor_generic_check<byte>();

        public void bmxor_generic_check_16x16()
            => bmxor_generic_check<ushort>();

        public void bmxor_generic_check_32x32()
            => bmxor_generic_check<uint>();

        public void bmxor_generic_check_64x64()
            => bmxor_generic_check<ulong>();
        

        void bmxor_generic_check<T>()
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