//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public class t_bm_transpose : t_bm<t_bm_transpose>
    {
        public void bm_transpose_8x8x8_v2()
        {
            var n = n8;
            var m1 = Random.BitMatrix(n);
            var m2 = BitMatrix.transpose_v2(m1);
            for(var i=0; i<n; i++)
            for(var j=0; j<n; j++)
                Claim.Eq(m1[i,j], m2[j,i]);
            
            var m3 = BitMatrix.transpose_v2(m2);
            Claim.Require(m3 == m1);
        }

        public void bm_transpose_8x8x8()
        {
            var n = n8;
            var m1 = Random.BitMatrix(n);
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.Require(m3 == m1);
        }

        public void bm_transpose_16x16x16()
        {
            var n = n16;
            var m1 = Random.BitMatrix(n);
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.Require(m3 == m1);
        }

        public void bm_transpose_32x32x32()
        {
            var n = n32;
            var m1 = Random.BitMatrix(n);
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.Require(m3 == m1);
        }

        public void bm_transpose_64x64x64()
        {
            var n = n64;
            var m1 = Random.BitMatrix(n);
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.Require(m3 == m1);    
        }

        public void bm_transpose_n12x14x16()
            => bm_transpose_check<N12,N14,short>();

        void bm_transpose_n13x64x64()
            => bm_transpose_check<N13,N64,ulong>();

        void bm_transpose_n13x64x32()
            => bm_transpose_check<N13,N64,uint>();

        public void bm_transpose_n32x32x64()
            => bm_transpose_check<N32,N32,ulong>();

        public void bm_transpose_n8x8x8()
            => bm_transpose_check<N8,N8,byte>();
    }
}