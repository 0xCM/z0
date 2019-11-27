//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_extract : t_bm<t_bm_extract>
    {
        public void VectorExtract()
        {
            nbm_check_extract(Random.BitMatrix<N9,N9,byte>());
            nbm_check_extract(Random.BitMatrix<N9,N9,ushort>());
            nbm_check_extract(Random.BitMatrix<N128,N128,uint>());
            nbm_check_extract(Random.BitMatrix<N16,N128,uint>());
            nbm_check_extract(Random.BitMatrix<N5,N7,uint>());            
        }

        
        public void pbm_eq_32()
        {
            var x = Random.BitMatrix(n32);
            var y = Random.BitMatrix(n32);
            Claim.nea(x.Equals(y));
            Claim.yea(x.Equals(x));
            Claim.yea(y.Equals(y));
        }

        public void pbm_eq_64()
        {
            var x = Random.BitMatrix(n64);
            var y = Random.BitMatrix(n64);
            Claim.nea(x.Equals(y));
            Claim.nea(x == y);
            Claim.yea(x != y);
            Claim.yea(x.Equals(x));
            Claim.yea(y.Equals(y));
        }

        public void pbm_not_64()
        {            
            var x = Random.BitMatrix(n64);
            var y = x.Replicate();
            var xff = ~(~x);
            Claim.yea(xff == y);

            var c = Random.BitMatrix(n64);
            var a = new ulong[64];
            for(var i = 0; i<64; i++)
                a[i] = ~ c[i];
            var b = BitMatrix.primal(n64,a);
            Claim.yea(b == ~c);        
        }

        public void pbm_col_8()
        {
            for(var j = 0; j< SampleSize; j++)
            {
                var src = Random.BitMatrix8();
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = src.Col(c);
                    for(var r=0; r<src.Order; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }
        }

        public void pbm_col_16()
        {
            for(var j = 0; j< SampleSize; j++)
            {
                var src = Random.BitMatrix16();
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = src.Col(c);
                    for(var r=0; r<src.Order; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }
        }

        public void pbm_col_32()
        {
            for(var j = 0; j< SampleSize; j++)
            {
                var src = Random.BitMatrix(n32);
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = BitMatrix.col(src,c);
                    for(var r=0; r<src.Order; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }
        }

        public void pbm_col_64()
        {
            for(var j = 0; j< SampleSize; j++)
            {
                var src = Random.BitMatrix(n64);
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = src.Column(c);
                    for(var r=0; r<src.Order; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }
        }
    }
}