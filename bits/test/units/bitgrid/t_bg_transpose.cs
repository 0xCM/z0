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

        public void fbg_64_transpose_8x8()
        {
            var m = n8;
            var n = n8;
            var t = z8;
            var w = n64;

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


    }

}