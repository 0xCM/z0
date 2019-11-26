//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_col : t_bg<t_bg_col>
    {        

        public void bg_col_32x2()
        {
            var m = n32;
            var n = n2;
            var xg = Random.BitGrid(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);

            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            
        }


        public void bg_col_8x4()
        {
            var m = n8;
            var n = n4;
            var xg = Random.BitGrid(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);

            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            
        }

        public void bg_col_64()
        {

            var m = n8;
            var n = n8;
            var xg = Random.BitGrid(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);
            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            

        }

        public void bg_col_256()
        {
            var block = n256;
            var m = n32;
            var n = n8;
            var xg = Random.BitGrid<ulong>(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);
            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            
        }

        public void bg_col_128()
        {
            var block = n128;
            var m = n16;
            var n = n8;
            var xg = Random.BitGrid<ulong>(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);
            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            

        }
    }

}