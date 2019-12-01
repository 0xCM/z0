//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_nbg_define : t_bg<t_nbg_define>
    {        

        public void nbg_define_3x5x8()
            => nbg_define_check(n3, n5, z8);

        public void nbg_define_17x11x8()
            => nbg_define_check(n17, n11, z8);

        public void nbg_define_30x30x32()
            => nbg_define_check(n30, n30, z32);

        public void nbg_define_32x32x64()
            => nbg_define_check(n32, n32, z64);

        public void nbg_define_32x33x64()
            => nbg_define_check(n32, n33, z64);

        public void nbg_define_32x34x64()
            => nbg_define_check(n32, n34, z64);

        public void nbg_define_32x35x64()
            => nbg_define_check(n32, n35, z64);

        public void nbg_define_42x32x64()
            => nbg_define_check(n42, n32, z64);

        public void nbg_define_33x42x64()
            => nbg_define_check(n33,n42, z64);

        public void nbg_define_34x37x64()
            => nbg_define_check(n34, n37, z64);

        public void nbg_define_35x35x64()
            => nbg_define_check(n35, n35, z64);

        public void nbg_define_35x55x64()
            => nbg_define_check(n55, n55, z64);

        public void nbg_define_35x55x8()
            => nbg_define_check(n55, n55, z8);

        public void nbg_define_basecase()
        {
            //dim: 128x128
            //512 32-bit integers

            //32 32 32 32   row[0]
            //32 32 32 32   row[1]
            // ....
            //32 32 32 32   row[127]

            // Linear index 0 ... 511            
            // 0    1   2   3 
            // 4    5   6   7
            // 8    9   10  11
            // ...
            // 496 497 498 499
            // 500 501 502 503
            // 504 505 506 507
            // 508 509 510 511


            var w = n512;
            var n = n128;
            var cpr = 4; //cells per row

            var grid = BitGrid.alloc(n128, n128, z32);            
            Random.Fill(grid);
            
            var g128 = grid.Data.Reblock(n128);
            var g32 = grid.Data.Reblock(n32);
            Claim.eq(g32.BlockCount,w);

            ref var g32src = ref g32.Head;
            
            var row124 = ginx.vload(n, g32.BlockSeek(124*cpr));
            var row125 = ginx.vload(n, g32.BlockSeek(125*cpr));
            var row126 = ginx.vload(n, g32.BlockSeek(126*cpr));
            var row127 = ginx.vload(n, g32.BlockSeek(127*cpr));
            
            var diagA = dinx.vgather(n, ref g32src, dinx.vpartsi(n, 496, 501, 506, 511));
            var diagB = dinx.vparts(n, g32[496], g32[501], g32[506], g32[511]);
            Claim.eq(diagA,diagB);
        }

    }

}
