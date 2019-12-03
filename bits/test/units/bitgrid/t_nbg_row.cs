//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_nbg_row : t_bg<t_nbg_row>
    {        
        public void nbg_row_32x8x4()
        {
            var m = n8;
            var n = n4;
            var t = z32;
            
            var bg = Random.BitGrid(m,n,t);
            var bs = bg.ToBitString();
            var data = bg.Data;

            for(var r = 0; r < m; r++)
            {                
                var r1 = BitGrid.row(bg,r);
                var r2 = bs.Slice(r*n,n);
                var r3 = BitGrid.nrow(bg,r);
                Claim.eq(r1, r2.ToBitVector(n4));                
                Claim.eq(r1, r3);
            }
        }

        public void nbg_row_256x16x16()
        {
            var m = n16;
            var n = n16;
            var t = z16;
            
            var bg = Random.BitGrid(m,n,t);
            var bs = bg.ToBitString();
            var data = bg.ToSpan();
            
            for(var i = 0; i<m; i++)
            {
                var row1 = BitGrid.row(bg,i);
                var row2 = data[i].ToBitVector();
                Claim.eq(row1,row2);
            }
        }
    }

}