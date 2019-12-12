//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;
    
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
                   

                   

    }

}