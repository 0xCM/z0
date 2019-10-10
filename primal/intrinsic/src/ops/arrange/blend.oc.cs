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
        public static Vec128<short> vblend_128x16u_LLLLLLLL(in Vec128<short> x, in Vec128<short> y)        
            => dinx.vblend(x,y,Blend16x8.LLLLLLLL);

        public static Vec128<short> vblend_128x16u_RRRRRRRR(in Vec128<short> x, in Vec128<short> y)        
            => dinx.vblend(x,y,Blend16x8.RRRRRRRR);

        public static Vec128<short> vblend_128x16u_LLLLRRRR(in Vec128<short> x, in Vec128<short> y)        
            => dinx.vblend(x,y,Blend16x8.LLLLRRRR);

        public static Vec128<short> vblend_128x16u_RRRRLLLL(in Vec128<short> x, in Vec128<short> y)        
            => dinx.vblend(x,y,Blend16x8.RRRRLLLL);

        public static Vec128<short> vblend_128x16u_LRLRLRLR(in Vec128<short> x, in Vec128<short> y)        
            => dinx.vblend(x,y,Blend16x8.LRLRLRLR);

        public static Vec128<short> vblend_128x16u_RLRLRLRL(in Vec128<short> x, in Vec128<short> y)        
            => dinx.vblend(x,y,Blend16x8.RLRLRLRL);

        public static Vec128<uint> vblend_128x32u_LLLL(in Vec128<uint> x, in Vec128<uint> y)        
            => dinx.vblend(x,y,Blend32x4.LLLL);

        public static Vec128<uint> vblend_128x32u_RRRR(in Vec128<uint> x, in Vec128<uint> y)        
            => dinx.vblend(x,y,Blend32x4.RRRR);

        public static Vec128<uint> vblend_128x32u_RRLL(in Vec128<uint> x, in Vec128<uint> y)        
            => dinx.vblend(x,y,Blend32x4.RRLL);

        public static Vec128<uint> vblend_128x32u_LLRR(in Vec128<uint> x, in Vec128<uint> y)        
            => dinx.vblend(x,y,Blend32x4.LLRR);

        public static Vec128<uint> vblend_128x32u_LRLR(in Vec128<uint> x, in Vec128<uint> y)        
            => dinx.vblend(x,y,Blend32x4.LRLR);

        public static Vec128<uint> vblend_128x32u_RLRL(in Vec128<uint> x, in Vec128<uint> y)        
            => dinx.vblend(x,y,Blend32x4.RLRL);


        public static Vec256<ushort> vblend_256x16u_LLLLRRRR(in Vec256<ushort> x, in Vec256<ushort> y)        
            => dinx.vblend(x,y,Blend16x8.LLLLRRRR);

    }

}