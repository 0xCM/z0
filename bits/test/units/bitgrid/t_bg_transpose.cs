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

        public void algorithm()
        {

            /*
                1   2   3   4
                5   6   7   8
                9   10  11  12
                13  14  15  16


                1   5   9   13
                2   6   10  14
                3   7   11  15
                4   8   12  16

                1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16
                1   5   9   13  2   6   10  14  3   7   11  15  4   8   12  16

            */

        }


        public void nbg_transpose_8x8()
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