//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_create : t_bm<t_bm_create>
    {

        public void create_16x16_from_fixed()
        {
            var data = Random.Span<ushort>(16);
            var src = FixedStore.alloc(n256);
            FixedStore.deposit(in head(data), ref src);
            var A = BitMatrix.primal(n16, FixedStore.bytes(src));
            var B = BitMatrix.primal(n16, data);
            Claim.yea(BitMatrix.same(A,B));
        }

        public void create_8x8()
        {
            var src = Random.Stream<ulong>().Take(Pow2.T07).GetEnumerator();
            while(src.MoveNext())
            {
                var m1 = BitMatrix.primal(n8,src.Current);
                var n = new N8();
                var m2 = BitMatrix.load(n, n,src.Current.ToBytes().ToSpan());
                for(var i=0; i<8; i++)
                for(var j=0; j<8; j++)
                    Claim.eq(m1[i,j], m2[i,j]);
            }
        }

        public void create8x8_from_perm()
        {
            const uint n = BitMatrix8.N;

            var p = Random.Perm<N8>();
            var m = p.ToBitMatrix();

            for(var i=0; i<n; i++)
            for(var j=0; j<n; j++)
            {
                if(p[i] == j)
                    Claim.eq(m[i,j], on);
                else
                    Claim.eq(m[i,j], off);
            }
        }

        public void create16x16_from_perm()
        {
            const uint n = BitMatrix16.N;

            for(var sample=0; sample<SampleSize; sample++)
            {
                var p = Random.Perm<N16>();
                var m = p.ToBitMatrix();

                for(var i=0; i<n; i++)
                for(var j=0; j<n; j++)
                {
                    if(p[i] == j)
                        Claim.eq(m[i,j], on);
                    else
                        Claim.eq(m[i,j], off);
                }
            }
        }

        public void create64x64_from_perm()
        {
            const uint n = BitMatrix64.N;

            for(var sample=0; sample<SampleSize; sample++)
            {
                var p = Random.Perm<N64>();
                var m = p.ToBitMatrix();

                for(var i=0; i<n; i++)
                for(var j=0; j<n; j++)
                {
                    if(p[i] == j)
                        Claim.eq(m[i,j], on);
                    else
                        Claim.eq(m[i,j], off);
                }

            }
        }

        public void nbm_create_7x9x8()
        {
            var m1 = BitMatrix.alloc<N7,N9,byte>();
            m1.Fill(Bit.On);
            var fmt = m1.Format().RemoveWhitespace();
            Claim.eq(BitMatrix<N7,N9,byte>.TotalBitCount, fmt.Length);    

        }

        public void nbm_broadcast_7x9x8()
        {
            const byte pattern = 0b01010101;
            var fill = BitCells.alloc(n9, pattern);
            var matrix = BitMatrix.broadcast(fill, n7);
            for(var i=0; i<matrix.RowCount; i++)
                Claim.yea(fill == matrix[i]);
        }

        public void nbm_create_7x7x8()
        {
            var m1 = BitMatrix.alloc<N7,byte>();
            m1.Fill(on);
            var fmt = m1.Format().RemoveWhitespace();
            Claim.eq(7*7, fmt.Length);
            var d = m1.Diagonal();
            var x = BitCells.alloc<N7,byte>();
            x.Fill(on);

            Claim.yea(d == x);                        
        }
    }
}
