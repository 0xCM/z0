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

        public void bm_create_fromfixed_16x16x16()
        {
            var data = Random.Span<ushort>(16);
            var src = FixedStore.alloc(n256);
            FixedStore.deposit(in head(data), ref src);
            var A = BitMatrix.primal(n16, FixedStore.bytes(src));
            var B = BitMatrix.primal(n16, data);
            Claim.yea(BitMatrix.same(A,B));
        }

        public void bm_load_8x8x8()
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

        public void bm_format_n7x9x8()
        {
            var m1 = BitMatrix.alloc<N7,N9,byte>();
            m1.Fill(bit.On);
            var fmt = m1.Format().RemoveWhitespace();

            Claim.eq(7*9, fmt.Length);    

        }

        public void bm_init_n7x9x8()
        {
            const byte pattern = 0b01010101;
            var fill = BitSpan.init(n9, pattern);
            var matrix = BitMatrix.init(fill, n7);
            for(var i=0; i<matrix.RowCount; i++)
                Claim.yea(fill == matrix[i]);
        }

    }
}
