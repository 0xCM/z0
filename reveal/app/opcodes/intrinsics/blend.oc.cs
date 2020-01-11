//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    public static class vblend
    {
        [MethodImpl(Inline)]
        static byte makespec<A,B,C,D>(A a = default, B b = default, C c = default, D d = default)
            where A : unmanaged, ITypeNat
            where B : unmanaged, ITypeNat
            where C : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
                =>(byte)(Nat.value(a) | Nat.value(b) << 2 | Nat.value(c) << 4 | Nat.value(d) << 6);

        public static byte natcompute()
        {
            return makespec(n2,n1,n0,n3);
        }
        public static Vector512<ushort> vblendp_256x16u(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> spec)
            => ginx.vblendp(x,y,spec);
            
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