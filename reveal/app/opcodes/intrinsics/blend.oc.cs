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
        public static Vector256<ushort> vmerge16(Vector128<ushort> x, Vector128<ushort> y)                
            => dinx.vmerge(x,y, Blend8x16.LLRRLLRR, Blend8x16.RRLLRRLL);

        public static Vector256<uint> vmerge32(Vector128<uint> x, Vector128<uint> y)                
            => dinx.vmerge(x,y, Blend4x32.LLRR, Blend4x32.LLRR);

        public static Vector256<ulong> vmerge64(Vector128<ulong> x, Vector128<ulong> y)                
            => dinx.vmerge(x,y, Blend2x64.LR, Blend2x64.RL);

        public static Vector128<ulong> vreverse_128x64u(Vector128<ulong> x)
            => dinx.vreverse(x);

        public static Vector128<byte> vreverse_128x8u(Vector128<byte> x)
            => dinx.vreverse(x);

        public static Vector256<byte> vreverse_256x8u(Vector256<byte> x)
            => dinx.vreverse(x);


        public static Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend8x16.LLLLLLLL);

        public static Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend8x16.RRRRRRRR);

        public static Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend8x16.LLLLRRRR);

        public static Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend8x16.RRRRLLLL);

        public static Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend8x16.LRLRLRLR);

        public static Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)        
            => dinx.vblend(x,y,Blend8x16.RLRLRLRL);



    }

}