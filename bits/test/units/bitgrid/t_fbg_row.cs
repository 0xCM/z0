//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_fbg_row : t_bg<t_fbg_row>
    {        
        public void fbg_row_8x4x32()
        {
            var m = n8;
            var n = n4;
            var t = z32;
            
            var bg = Random.BitGrid(m,n,t);
            var bs = bg.ToBitString();
            var data = bg.Data;

            for(var r = 0; r < m; r++)
            {                
                var bv1 = BitGrid.row(bg,r);
                var bs1 = bs.Slice(r*n,n);
                Claim.eq(bv1, bs1.ToBitVector(n4));                
            }
        }

        public void fbg_row_16x16x256()
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