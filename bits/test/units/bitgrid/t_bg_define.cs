//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_define : t_bg<t_bg_define>
    {        
        public void gbg_define_32x32x32()
        {
            var n = n32;
            var zero = 0u;
            var matrix = Random.BitMatrix(n);
            var grid = matrix.ToBitGrid();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                Claim.eq(grid[row,col], matrix[row,col]);

            nbg_define_check(n,n,zero);
        }

        public void gbg_define_64x64x64()
        {
            var n = n64;
            var zero = 0ul;
            var matrix = Random.BitMatrix(n);
            var grid = matrix.ToBitGrid();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                Claim.eq(grid[row,col], matrix[row,col]);

            nbg_define_check(n,n,zero);                
        }

        public void nbg_define_3x5x8()
            => nbg_define_check(n3,n5, z8);

        public void nbg_define_17x11x8()
            => nbg_define_check(n17,n11, z8);

        public void nbg_define_30x30x32()
            => nbg_define_check(n30,n30, z32);


    }

}