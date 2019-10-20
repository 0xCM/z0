//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class inxvoc
    {
        public static Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<int> spec)
            => dinx.vpermvar8x32(src,spec);

        public static Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
            => dinx.vpermvar8x32(src,spec);

        public static Vector256<float> vpermvar8x32_256x32f(Vector256<float> src, Vector256<int> spec)
            => dinx.vpermvar8x32(src,spec);

        public static Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
            => dinx.vpermvar32x8(a,spec);
 
    }
}