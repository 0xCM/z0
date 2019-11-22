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

    public class t_bm_create : BitMatrixTest<t_bm_create>
    {
        public void permrev_8x8()
        {
            for(var i= 0; i<SampleSize; i++)
            {
                //Creates an "exchange" matrix
                var perm = Perm.identity(n8).Reverse();
                var mat = perm.ToBitMatrix();

                var v1 = Random.BitVector(n8);
                var v2 = mat * v1;
                var v3 = v1.Replicate();
                v3.Reverse();
                Claim.eq(v3,v2);
            }
        }
        public void permrev_32x32()
        {
            for(var i= 0; i<SampleSize; i++)
            {
                //Creates an "exchange" matrix            
                var perm = Perm.identity(n32).Reverse();
                var mat = perm.ToBitMatrix();

                var v1 = Random.BitVector(n32);
                var v2 = mat * v1;
                var v3 = v1.Replicate();
                v3.Reverse();
                Claim.eq(v3,v2);
            }
        }

        public void permrev_64x64()
        {
            for(var i= 0; i<SampleSize; i++)
            {
                //Creates an "exchange" matrix            
                var perm = Perm.identity(n64).Reverse();
                var mat = perm.ToBitMatrix();

                var v1 = Random.BitVector(n64);
                var v2 = mat * v1;
                var v3 = v1.Replicate();
                v3 = BitVector.rev(v3);
                Claim.eq(v3,v2);
            }
        }

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

        public void create9x4()
        {
            var grid = BitGridSpec.define<N9,N4,byte>();    
            Claim.eq(9, grid.RowCount);
            Claim.eq(4, grid.ColCount);

            var layout = grid.CalcLayout();
            Claim.eq(36, layout.BitCount);
            Claim.eq(9, layout.RowCount);
            Claim.eq(4, layout.ColCount);
            Claim.eq(1, layout.RowCellCount);
            Claim.eq(9, layout.TotalCellCount);
            var row0 = layout.Row(0);
            
            Claim.eq(4, row0.Length);            
            Claim.eq(0, row0[0].Col);
            Claim.eq(3, row0[3].Col);
            Claim.eq(0, (int)row0[3].Segment);

            var row8 = layout.Row(8);
            Claim.eq(4, row8.Length);
            Claim.eq(8, (int)row8[3].Segment);

            var m = BitMatrix.ones<N9,N4,byte>();
            Claim.eq(9,m.RowCount);
            Claim.eq(4,m.ColCount);
            for(var i=0; i< m.RowCount; i++)
            {
                for(var j=0; j<m.ColCount; j++)
                    Claim.eq(m[i,j], Bit.On);
            }            
        }

        public void create_7x9x8u()
        {
            var m1 = BitMatrix.alloc<N7,N9,byte>();
            m1.Fill(Bit.On);
            var fmt = m1.Format().RemoveWhitespace();
            Claim.eq(BitMatrix<N7,N9,byte>.TotalBitCount, fmt.Length);    

        }

        public void broadcast_7x9x8u()
        {
            const byte pattern = 0b01010101;
            var fill = BitVector.alloc(n9, pattern);
            var matrix = BitMatrix.broadcast(fill, n7);
            for(var i=0; i<matrix.RowCount; i++)
                Claim.yea(fill == matrix[i]);
        }

        public void create7x7()
        {
            var m1 = BitMatrix.alloc<N7,byte>();
            m1.Fill(on);
            var fmt = m1.Format().RemoveWhitespace();
            Claim.eq(7*7, fmt.Length);
            var d = m1.Diagonal();
            var x = BitVector.alloc<N7,byte>();
            x.Fill(on);

            Claim.yea(d == x);                        
        }

        public void create16x16()
        {
            var spec = BitGridSpec.define<N16,N16,byte>();    
            Claim.eq(16, spec.RowCount);
            Claim.eq(16, spec.ColCount);

            var layout = spec.CalcLayout();

            int rowCount = 0, bitpos = 0;
            for(var row=0; row < layout.RowCount; row++)
            {
                rowCount++;
                var cells = layout.Row(row);
                for(var col=0; col< layout.ColCount; col++, bitpos++)
                {

                    var cell = cells[col];

                    Claim.eq(bitpos, cell.Position);
                    Claim.eq(row, cell.Row);
                    Claim.eq(col, cell.Col);
                }
            }
            Claim.eq(256, bitpos);
            Claim.eq(256, layout.BitCount);
            
            Claim.eq(16, layout.RowCount);
            Claim.eq(16, rowCount);
            
            Claim.eq(16, layout.ColCount);
            Claim.eq(2, layout.RowCellCount);
            Claim.eq(32, layout.TotalCellCount);

            var row0 = layout.Row(0);
            
            Claim.eq(16, row0.Length);            
            Claim.eq(0, row0[0].Col);
            Claim.eq(3, row0[3].Col);
            Claim.eq(1, (int)row0[9].Segment);

            var m = BitMatrix.ones<N16,byte>();
            Claim.eq(16, m.RowCount);
            Claim.eq(16, m.ColCount);
            Claim.eq(2, m.RowSegCount);
            
            for(var i=0; i < m.RowCount; i++)
            for(var j=0; j < m.ColCount; j++)
                Claim.eq(on, m[i,j]);
        }
    }
}
