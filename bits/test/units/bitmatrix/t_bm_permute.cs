//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_permute : t_bm<t_bm_permute>
    {
        public void bm_permrev_8x8()
        {
            for(var i= 0; i<SampleSize; i++)
            {
                //Creates an "exchange" matrix
                var perm = Perm.natural(n8).Reverse();
                var mat = perm.ToBitMatrix();

                var v1 = Random.BitVector(n8);
                var v2 = mat * v1;
                var v3 = v1.Replicate();
                v3 = BitVector.rev(v3);
                Claim.eq(v3,v2);
            }
        }
        public void bm_permrev_32x32()
        {
            for(var i= 0; i<SampleSize; i++)
            {
                //Creates an "exchange" matrix            
                var perm = Perm.natural(n32).Reverse();
                var mat = perm.ToBitMatrix();

                var v1 = Random.BitVector(n32);
                var v2 = mat * v1;
                var v3 = v1.Replicate();
                Claim.eq(v3.Reverse(),v2);
            }
        }

        public void bm_permrev_64x64()
        {
            for(var i= 0; i<SampleSize; i++)
            {
                //Creates an "exchange" matrix            
                var perm = Perm.natural(n64).Reverse();
                var mat = perm.ToBitMatrix();

                var v1 = Random.BitVector(n64);
                var v2 = mat * v1;
                var v3 = v1.Replicate();
                v3 = BitVector.rev(v3);
                Claim.eq(v3,v2);
            }
        }
        
        void permute_check<T>()
            where T : unmanaged
        {
            
            var A = BitMatrix.identity<T>();
            var N = BitMatrix<T>.N;
            for(var i=0; i< SampleSize; i++)
            {
                var perm = Random.Perm(N);
                BitMatrix.permute(perm, ref A);
            }
        }
    }

}