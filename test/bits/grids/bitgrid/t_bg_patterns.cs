//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    
    public class t_bg_patterns : t_bg<t_bg_patterns>
    {        
        void stripes_12x12()
            => BitGrid.export(GridPatterns.stripes(n256,n12,n12,z16));
                   
        void bars_16x16()        
            => BitGrid.export(GridPatterns.bars(n256,n16,n16,z16));

        void xcross_16x16()
            => BitGrid.export(BitGrid.xor(GridPatterns.stripes(n256, n16,n16,z16), GridPatterns.bars(n256, n16,n16,z16)));

        void exchange_rotl_4_16x16()        
            => BitGrid.export(BitGrid.rotl(GridPatterns.exchange(n256,n16,n16,z16), 4));

        void exchange_rotr_4_16x16()        
            => BitGrid.export(BitGrid.rotr(GridPatterns.exchange(n256,n16,n16,z16), 4));
        
        void identity_4x4()
            => BitGrid.export(GridPatterns.identity(n16,n4,n4,z16));

        void identity_5x5()
            => BitGrid.export(GridPatterns.identity(n32,n5,n5,z32));

        void identity_8x8()
            => BitGrid.export(GridPatterns.identity(n64,n8,n8,z8));

        void identity_16x16()
            => BitGrid.export(GridPatterns.identity(n256,n16,n16,z16));

        void exchange_16x16()
            => BitGrid.export(GridPatterns.exchange(n256,n16,n16,z16));
        
        void identity_rotl_4_16x16()        
            => BitGrid.export(BitGrid.rotl(GridPatterns.identity(n256,n16,n16,z16), 4));

        void identity_rotr_4_16x16()        
            => BitGrid.export(BitGrid.rotr(GridPatterns.identity(n256,n16,n16,z16), 4));

    }
}