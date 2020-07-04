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

    public class t_bm_extract : t_bm<t_bm_extract>
    {    
        public void bm_extract_n9x9x16()
            => bm_extract_check(Random.BitMatrix<N9,N9,ushort>());

        public void bm_extract_n5x7x32()
            => bm_extract_check(Random.BitMatrix<N5,N7,uint>());

        public void bm_extract_n5x7x64()
            => bm_extract_check(Random.BitMatrix<N5,N7,ulong>());

        public void bm_extract_n9x8x16()
            => bm_extract_check(Random.BitMatrix<N9,N8,ushort>());

        public void bm_extract_n33x11x64()
            => bm_extract_check(Random.BitMatrix<N33,N11,ulong>());

        void bm_extract_n128x128x64()
            => bm_extract_check(Random.BitMatrix<N128,N128,ulong>());

        void bm_extract_n9x9x8()
            => bm_extract_check(Random.BitMatrix<N9,N9,byte>());

        void bm_extract_n128x128x32()
            => bm_extract_check(Random.BitMatrix<N128,N128,ushort>());

        void bm_extract_n16x128x32()
            => bm_extract_check(Random.BitMatrix<N16,N128,ushort>());

        public void bm_eq_32x32x32()
        {
            var x = Random.BitMatrix(n32);
            var y = Random.BitMatrix(n32);
            Claim.nea(x.Equals(y));
            Claim.Require(x.Equals(x));
            Claim.Require(y.Equals(y));
        }

        public void bm_eq_64x64x64()
        {
            var x = Random.BitMatrix(n64);
            var y = Random.BitMatrix(n64);
            Claim.nea(x.Equals(y));
            Claim.nea(x == y);
            Claim.Require(x != y);
            Claim.Require(x.Equals(x));
            Claim.Require(y.Equals(y));
        }

        public void bm_not_64x64x64()
        {            
            var x = Random.BitMatrix(n64);
            var y = x.Replicate();
            var xff = ~(~x);
            Claim.Require(xff == y);

            var c = Random.BitMatrix(n64);
            var a = new ulong[64];
            for(var i = 0; i<64; i++)
                a[i] = ~ c[i];
            var b = BitMatrix.primal(n64,a);
            Claim.Require(b == ~c);        
        }

        public void bm_getcol_8x8x8()
        {
            for(var j = 0; j< RepCount; j++)
            {
                var src = Random.BitMatrix8();
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = src.Col(c);
                    for(var r=0; r<src.Order; r++)
                        Claim.Eq(col[r], src[r,c]);
                }
            }
        }

        public void bm_getcol_16x16x16()
        {
            for(var j = 0; j< RepCount; j++)
            {
                var src = Random.BitMatrix16();
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = src.Col(c);
                    for(var r=0; r<src.Order; r++)
                        Claim.Eq(col[r], src[r,c]);
                }
            }
        }

        public void bm_getcol_32x32x32()
        {
            for(var j = 0; j< RepCount; j++)
            {
                var src = Random.BitMatrix(n32);
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = BitMatrix.col(src,c);
                    for(var r=0; r<src.Order; r++)
                        Claim.Eq(col[r], src[r,c]);
                }
            }
        }

        public void bm_getcol_64x64x64()
        {
            for(var j = 0; j< RepCount; j++)
            {
                var src = Random.BitMatrix(n64);
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = src.Column(c);
                    for(var r=0; r<src.Order; r++)
                        Claim.Eq(col[r], src[r,c]);
                }
            }
        }
    }
}