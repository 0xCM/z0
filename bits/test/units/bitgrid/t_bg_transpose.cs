//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_transpose : t_bg<t_bg_transpose>
    {        
        static Span<int> GetPositions<M,N>(int col, M m= default, N n = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            Span<int> positions = new int[natval(m)];
            for(var row = 0; row < positions.Length; row++)
                positions[row] = BitGrid.colidx(n, row, col);
            return positions;
        }
        static Span<int> GetSegments<M,N,T>(int col, M m= default, N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
        {
            var positions = GetPositions(col,m,n);
            var segwidth = bitsize<T>();
            Span<int> segments = new int[natval(m)];            
            for(var i=0; i<positions.Length; i++)
                segments[i] = positions[i]/segwidth;
            return segments;
        }

        public void bg_transpose_256x16x16()
        {            
            var w = n256;
            var m = n16;
            var n = n16;
            var t = z16;
            ushort pattern = 0b1100110011001100;

            var g = BitGrid.broadcast(w, pattern, m,n);
            var gT = BitGrid.transpose(g);
            var bsT = g.ToBitString().Transpose(m,n).ToBitGrid(w,m,n,t);
            Claim.yea(gT == bsT);

        }

        void nbg_transpose_8x8()
        {
            var w = n64;
            var m = n8;
            var n = n8;
            var t = z8;

            for(var i=0; i<SampleSize; i++)
            {
                var g = Random.BitGrid(m,n,t);
                var gt = BitGrid.transpose(g);
                var bs = g.ToBitString();
                var bst = bs.Transpose(m,n);
                var bstg = bst.ToBitGrid(w,n,m,t);
                if(gt != bstg)
                {
                    Trace(gt.Format());
                    Trace("!=");
                    Trace(bstg.Format());
                    Claim.fail();
                }

            }
        }

        public void nbg_transpose_16x4()
        {
            var w = n64;
            var m = n16;
            var n = n4;
            var t = z64;

            for(var i=0; i<SampleSize;i++)
            {
                var g = Random.BitGrid(m,n,t);
                var tr1 = BitGrid.transpose(g);
                var tr2 = BitGrid.transpose2(g);
                var tr3 = g.ToBitString().Transpose(m,n).ToBitGrid(w,n,m,t);

                if(tr1 != tr3)
                {
                    Trace(tr1.Format());
                    Trace("!=");
                    Trace(tr3.Format());
                    Claim.fail();
                }

                if(tr1 != tr2)
                {
                    Trace(tr1.Format());
                    Trace("!=");
                    Trace(tr2.Format());
                    Claim.fail();

                }


            }

        }


    }

}