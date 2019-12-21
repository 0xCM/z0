//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    [OpCodeProvider]
    public static class vconvert
    {                


        public static ConstPair<Vector128<ushort>> vconvert_128x8_2x128x16u_tuple(Vector128<byte> src)
            => dinx.vconvert(src, n128,z16);

        public static ConstQuad<Vector128<uint>> vconvert_128x8u_4x128x32u_tuple(Vector128<byte> src)
            => dinx.vconvert(src, n128,z32);

        public static void vconvert_128x8u_2x256x32u_out(Vector128<byte> src, out Vector256<uint> lo, out Vector256<uint> hi)
            => dinx.vconvert(src, out lo, out hi);

        public static ConstPair<Vector256<uint>> vconvert_128x8u_2x256x32u_tuple(Vector128<byte> src)
            => dinx.vconvert(src,n256,z32);

        public static Vector128<byte> vcompact_128x16x2_128x8_v1(Vector128<ushort> x0, Vector128<ushort> x1)
            => dinx.vcompact(x0,x1);

        public static Vector256<byte> vcompact_256x16x2_256x8_v1(Vector256<ushort> x0, Vector256<ushort> x1)
            => dinx.vcompact(x0,x1);

        public static Vector128<ushort> vcompact_128x32x2_128x16_v1(Vector128<uint> x, Vector128<uint> y)
            => dinx.vcompact(x,y);

        public static Vector128<ushort> vcompact_128x32x2_128x16_v2(Vector128<uint> x, Vector128<uint> y)
            => dinx.vcompact2(x,y);

        public static Vector256<ushort> vcompact_256x32x2_128x16_v1(Vector256<uint> x, Vector256<uint> y)
            => dinx.vcompact(x,y);

        public static Vector256<ushort> vcompact_256x32x2_128x16_v2(Vector256<uint> x, Vector256<uint> y)
            => dinx.vcompact2(x,y);



        public static Vector128<byte> packus(Vector128<ushort> x,Vector128<ushort> y)
            => dinx.vpackus(x,y);

        public static Vector256<byte> packus(Vector256<ushort> x,Vector256<ushort> y)
            => dinx.vpackus(x,y);


    }

}
