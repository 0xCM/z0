//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    partial class inxvoc
    {
        public static Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend16x8.LLLLLLLL);

        public static Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend16x8.RRRRRRRR);

        public static Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend16x8.LLLLRRRR);

        public static Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend16x8.RRRRLLLL);

        public static Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend16x8.LRLRLRLR);

        public static Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend16x8.RLRLRLRL);



    }

}