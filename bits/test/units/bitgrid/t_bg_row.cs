//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    public class t_bg_row : t_bg<t_bg_row>
    {        
        public void bg_row_32x8x4()
        {
            var t = z32;
            var m = n8;
            var n = n4;
            
            for(var i=0; i<SampleSize; i++)
            {
                var bg = Random.BitGrid(m,n,t);
                var bs = BitGrid.bitstring(bg); 

                for(var row = 0; row < m; row++)
                {                
                    var r1 = BitGrid.row(bg,row);
                    var r2 = bs.Slice(row*n,n);
                    var r4 = BitVector.from(n, r2);
                    Claim.eq(r1, r4);
                }
            }
        }

        public void bg_row_32x4x8()
        {
            var t = z32;
            var m = n4;
            var n = n8;
            
            for(var i=0; i<SampleSize; i++)
            {
                var bg = Random.BitGrid(m,n,t);
                var bs = BitGrid.bitstring(bg); 

                for(var row = 0; row < m; row++)
                {                
                    var r1 = BitGrid.row(bg,row);
                    var r2 = bs.Slice(row*n,n);
                    var r4 = BitVector.from(n, r2);
                    Claim.eq(r1, r4);
                }
            }
        }


        public void bg_row_256x4x64()
        {
            var w = n256;
            var m = n4;
            var n = n64;
            var t = z64;
            
            for(var i=0; i<SampleSize; i++)
            {
                var bg = Random.BitGrid(m,n,t);
                var bs = BitGrid.bitstring(bg); 
                var bd = BitGrid.store(bg);
                
                for(var row = 0; row<m; row++)
                {
                    var row1 = BitGrid.row(bg,row);
                    var row2 = bd[row].ToBitVector();
                    Claim.eq(row1,row2);
                }
            }
        }

        public void bg_row_256x16x16()
        {
            var t = z16;
            var m = n16;
            var n = n16;
            
            for(var i=0; i<SampleSize; i++)
            {
                var bg = Random.BitGrid(m,n,t);
                var bs = BitGrid.bitstring(bg); 
                var bd = BitGrid.store(bg);
                
                for(var row = 0; row<m; row++)
                {
                    var row1 = BitGrid.row(bg,row);
                    var row2 = bd[row].ToBitVector();
                    Claim.eq(row1,row2);
                }
            }
        }

        public void bg_row_128x32x4()
        {
            var t = z32;
            var m = n32;
            var n = n4;

            for(var sample = 0; sample < SampleSize; sample++)
            {
                var bg = Random.BitGrid(m,n,t);
                var bs = BitGrid.bitstring(bg);
                for(var row = 0; row<m; row++)
                {
                    var r1 = BitGrid.row(bg,row);
                    var r2 = BitVector.natural(bs.Slice(row*n,n), n, z8);
                    Claim.eq(r1,r2);
                }
            }
        }
    }
}