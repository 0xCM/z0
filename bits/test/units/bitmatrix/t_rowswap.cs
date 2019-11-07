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
    
    public class t_bmrowswap : BitMatrixTest<t_bmrowswap>
    {        
        public void bmrowswap_64u_check()
        {
            var A = Random.BitMatrix64();
            var a = A.Data.Replicate();

            Claim.eq(a.Length, 64);
            for(var sample=0; sample< SampleSize; sample++)
            {
                (var i, var j) = Random.NextPair(0,64);
                A.RowSwap(i,j);

                var tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            var B = BitMatrix64.From(a);
            Claim.yea(A == B);
                
        }

        public void leading_zeroes_8u()
        {
            var A = BitMatrix8.Identity;
            int i=0, j=7;
            Claim.eq(gbits.nlz(A[i++]), j--);
            Claim.eq(gbits.nlz(A[i++]), j--);
            Claim.eq(gbits.nlz(A[i++]), j--);
            Claim.eq(gbits.nlz(A[i++]), j--);
            Claim.eq(gbits.nlz(A[i++]), j--);
            Claim.eq(gbits.nlz(A[i++]), j--);
            Claim.eq(gbits.nlz(A[i++]), j--);
            Claim.eq(gbits.nlz(A[i]), j);
            Claim.eq(7,i);
            Claim.eq(0,j);
        }

        public void leading_zeroes_16u()
        {
            var A = BitMatrix16.Identity;
            var rows = A.RowCount;
            for(int i=0, j=rows - 1; i < rows; i++, j--)            
                Claim.eq(gbits.nlz(A[i++]), j--);

        }

        public void leading_zeroes_32u()
        {
            var A = BitMatrix32.Identity;
            var rows = A.RowCount;
            for(int i=0, j=rows - 1; i < rows; i++, j--)            
                Claim.eq(gbits.nlz(A[i++]), j--);

        }

        public void leading_zeroes_64u()
        {
            var A = BitMatrix64.Identity;
            var rows = A.RowCount;
            for(int i=0, j=rows - 1; i < rows; i++, j--)            
                Claim.eq(gbits.nlz(A[i++]), j--);

        }

    }

}
