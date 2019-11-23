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

    public class t_bm_transpose : BitMatrixTest<t_bm_transpose>
    {
        public void bm_transpose_12x14x16g()
            => bm_transpose_gn_check<N12,N14,short>();

        public void bm_transpose_13x64x32g()
            => bm_transpose_gn_check<N13,N64,uint>();

        public void bm_transpose_32x32x8g()
            => bm_transpose_gn_check<N32,N32,byte>();

        public void bm_transpose_8x8x8g()
            => bm_transpose_gn_check<N8,N8,byte>();

        public void bm_transpose_8x8()
        {
            var n = n8;
            var m1 = Random.BitMatrix(n);
            var m2 = BitMatrix.transpose_v2(m1);
            for(var i=0; i<n; i++)
            for(var j=0; j<n; j++)
                Claim.eq(m1[i,j], m2[j,i]);
            
            var m3 = BitMatrix.transpose_v2(m2);
            Claim.yea(m3 == m1);
        }

        public void bm_transpose_16x16x16()
        {
            var m1 = Random.BitMatrix(n16);
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);
        }

        public void bm_transpose_32x32()
        {
            var m1 = Random.BitMatrix(n32);
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);
        }

        public void bm_transpose_64x64()
        {
            var m1 = Random.BitMatrix(n64);
            var m2 = m1.Transpose();
            var m3 = m2.Transpose();
            Claim.yea(m3 == m1);    
        }

        void bm_transpose_gn_check<M,N,T>()
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample <SampleSize; sample++)
            {
                var src = Random.BitMatrix<M, N,T>();
                var tSrc = src.Transpose();
                for(var i=0; i<tSrc.RowCount; i++)
                for(var j=0; j<tSrc.ColCount; j++)
                    Claim.eq(tSrc[i,j], src[j,i]);
            }
        }
    }
}