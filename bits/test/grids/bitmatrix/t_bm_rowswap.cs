//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Nats;
    
    public class t_bm_rowswap : t_bm<t_bm_rowswap>
    {        
        public void bm_rowswap_16x16x16()
        {
            var n = n16;
            var A = Random.BitMatrix(n);
            
            var a = A.Data.Replicate();
            Claim.eq(a.Length, n);

            for(var sample=0; sample < RepCount; sample++)
            {
                (var i, var j) = Random.NextPair(0,n);
                A.RowSwap(i,j);

                var tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            var B = BitMatrix.primal(n,a);
            Claim.require(A == B);
        }


        public void bm_rowswap_64x64x64()
        {
            var n = n64;
            var A = Random.BitMatrix(n);
            
            var a = A.Data.Replicate();
            Claim.eq(a.Length, n);

            for(var sample=0; sample < RepCount; sample++)
            {
                (var i, var j) = Random.NextPair(0,n);
                A.RowSwap(i,j);

                var tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            var B = BitMatrix.primal(n,a);
            Claim.require(A == B);
                
        }

        public void bm_rowswap_32x32x32()
        {
            var n = n32;
            var A = Random.BitMatrix(n);
            
            var a = A.Data.Replicate();
            Claim.eq(a.Length, n);

            for(var sample=0; sample < RepCount; sample++)
            {
                (var i, var j) = Random.NextPair(0,n);
                BitMatrix.rowswap(A,i,j);

                var tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            var B = BitMatrix.primal(n,a);
            Claim.require(A == B);
        }
    }
}
