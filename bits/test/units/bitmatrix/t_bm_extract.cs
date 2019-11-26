//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    #pragma warning disable 1718

    public class t_bm_extract : t_bm<t_bm_extract>
    {
        public void VectorExtract()
        {
            check_extract(Random.BitMatrix<N9,N9,byte>());
            check_extract(Random.BitMatrix<N9,N9,ushort>());
            check_extract(Random.BitMatrix<N128,N128,uint>());
            check_extract(Random.BitMatrix<N16,N128,uint>());
            check_extract(Random.BitMatrix<N5,N7,uint>());            
        }

        
        public void eq_32x32()
        {
            var x = Random.BitMatrix(n32);
            var y = Random.BitMatrix(n32);
            Claim.nea(x.Equals(y));
            Claim.yea(x.Equals(x));
            Claim.yea(y.Equals(y));
        }

        public void eq_64x64()
        {
            var x = Random.BitMatrix(n64);
            var y = Random.BitMatrix(n64);
            Claim.nea(x.Equals(y));
            Claim.nea(x == y);
            Claim.yea(x != y);

            Claim.yea(x.Equals(x));
            Claim.yea(x == x);

            Claim.yea(y.Equals(y));
            Claim.yea(y == y);
        }

        public void not_64x64()
        {            
            var x = Random.BitMatrix(n64);
            var y = x.Replicate();
            var xff = ~(~x);
            Claim.yea(xff == y);

            var c = Random.BitMatrix(n64);
            var a = new ulong[64];
            for(var i = 0; i<64; i++)
                a[i] = ~ c[i];
            var b = BitMatrix64.From(a);
            Claim.yea(b == ~c);        
        }


        void check_extract<M,N,T>(BitMatrix<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var row=0; row< src.RowCount; row++)
            {
                var vector = src.RowVector(row);
                for(var col=0; col<vector.Length; col++)
                    Claim.eq(vector[col], src[row,col]);
            }
        }

        public void extract_col_8()
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

        public void extract_col_16()
        {
            for(var j = 0; j< SampleSize; j++)
            {
                var src = Random.BitMatrix16();
                for(var c = 0; c < src.ColCount; c ++)
                {
                    var col = src.Column(c);
                    for(var r=0; r<src.RowCount; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }
        }

        public void extract_col_32()
        {
            for(var j = 0; j< SampleSize; j++)
            {
                var src = Random.BitMatrix(n32);
                for(var c = 0; c < src.Order; c ++)
                {
                    var col = src.Column(c);
                    for(var r=0; r<src.Order; r++)
                        Claim.eq(col[r], src[r,c]);
                }
            }
        }

        public void extract_col_64()
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