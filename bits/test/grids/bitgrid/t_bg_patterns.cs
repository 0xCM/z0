//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Gone;
    
    public class t_bg_patterns : t_bg<t_bg_patterns>
    {        
        public void identity_4x4()
            => BitGrid.export(GridPattern.identity(n16,n4,n4,z16));

        public void identity_5x5()
            => BitGrid.export(GridPattern.identity(n32,n5,n5,z32));

        public void identity_8x8()
            => BitGrid.export(GridPattern.identity(n64,n8,n8,z8));

        public void identity_16x16()
            => BitGrid.export(GridPattern.identity(n256,n16,n16,z16));

        public void exchange_16x16()
            => BitGrid.export(GridPattern.exchange(n256,n16,n16,z16));

        
        public void stripes_12x12()
            => BitGrid.export(GridPattern.stripes(n256,n12,n12,z16));
                   
        public void bars_16x16()        
            => BitGrid.export(GridPattern.bars(n256,n16,n16,z16));

        public void identity_rotl_4_16x16()        
            => BitGrid.export(BitGrid.rotl(GridPattern.identity(n256,n16,n16,z16), 4));

        public void identity_rotr_4_16x16()        
            => BitGrid.export(BitGrid.rotr(GridPattern.identity(n256,n16,n16,z16), 4));

        public void exchange_rotl_4_16x16()        
            => BitGrid.export(BitGrid.rotl(GridPattern.exchange(n256,n16,n16,z16), 4));

        public void exchange_rotr_4_16x16()        
            => BitGrid.export(BitGrid.rotr(GridPattern.exchange(n256,n16,n16,z16), 4));

        public void xcross_16x16()
            => BitGrid.export(BitGrid.xor(GridPattern.stripes(n256, n16,n16,z16), GridPattern.bars(n256, n16,n16,z16)));

    }

}