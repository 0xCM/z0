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

    partial class inxoc
    {
        public static Vector128<ulong> vreverse_128x64u(Vector128<ulong> x)
            => dinx.vreverse(x);

        public static Vector128<byte> vreverse_128x8u(Vector128<byte> x)
            => dinx.vreverse(x);

        public static Vector256<byte> vreverse_256x8u(Vector256<byte> x)
            => dinx.vreverse(x);

        public static Vector128<byte> vrotlx_n8(Vector128<byte> x)
            => dinx.vrotlx(x, n8);

        public static Vector128<ulong> vrotlx_8(Vector128<ulong> x)
            => dinx.vrotlx(x, 1);

        public static Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend8x16(x,y,Blend8x16.LLLLLLLL);

        public static Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend8x16(x,y,Blend8x16.RRRRRRRR);

        public static Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend8x16(x,y,Blend8x16.LLLLRRRR);

        public static Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend8x16(x,y,Blend8x16.RRRRLLLL);

        public static Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend8x16(x,y,Blend8x16.LRLRLRLR);

        public static Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend8x16(x,y,Blend8x16.RLRLRLRL);



    }

}