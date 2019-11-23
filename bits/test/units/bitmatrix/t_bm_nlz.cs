//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bm_nlz : BitMatrixTest<t_bm_nlz>
    {        
        public void pbm_nlz_8()
        {
            var A = BitMatrix8.Identity;
            int i=0, j=7;
            Claim.eq(BitVector.nlz(A[i++]), j--);
            Claim.eq(BitVector.nlz(A[i++]), j--);
            Claim.eq(BitVector.nlz(A[i++]), j--);
            Claim.eq(BitVector.nlz(A[i++]), j--);
            Claim.eq(BitVector.nlz(A[i++]), j--);
            Claim.eq(BitVector.nlz(A[i++]), j--);
            Claim.eq(BitVector.nlz(A[i++]), j--);
            Claim.eq(BitVector.nlz(A[i]), j);
            Claim.eq(7,i);
            Claim.eq(0,j);
        }

        public void pbm_nlz_16()
        {
            var A = BitMatrix16.Identity;
            var rows = A.RowCount;
            for(int i=0, j=rows - 1; i < rows; i++, j--)            
                Claim.eq(BitVector.nlz(A[i++]), j--);
        }

        public void pbm_nlz_32()
        {
            var A = BitMatrix32.Identity;
            var rows = A.Order;
            for(int i=0, j=rows - 1; i < rows; i++, j--)            
                Claim.eq(BitVector.nlz(A[i++]), j--);
        }

        public void pbm_nlz_64()
        {
            var A = BitMatrix64.Identity;
            var rows = A.Order;
            for(int i=0, j=rows - 1; i < rows; i++, j--)            
                Claim.eq(BitVector.nlz(A[i++]), j--);
        }
    }
}