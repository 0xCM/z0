//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static TypedLogicSpec;

    public class t_bitmatrix_ops : UnitTest<t_bitmatrix_ops>
    {
    

        public void bm_and_check()
        {
            bm_and_check<N8,byte>();
            bm_and_check<N16,ushort>();
            bm_and_check<N32,uint>();
            bm_and_check<N64,ulong>();
        }

         void bm_and_check<N,T>()
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = inat<N>();

            for(var sample=0; sample< SampleSize; sample++)
            {
                BitMatrixOpApi.eval(BinaryBitwiseOpKind.And, A, B, ref C);
                for(var i=0; i<n; i++)
                {
                    var expect = A[i] & B[i];
                    var actual = C[i];
                    Claim.yea(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }


        }

    }
}
