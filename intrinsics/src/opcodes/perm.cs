//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class inxoc
    {
        public static Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
            => dinx.vbswap(x);
        public static Vector256<sbyte> vperm4x64(Vector256<sbyte> x)
            => dinx.vperm4x64(x, Perm4.ABCD);        
            
        public static Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
            => dinx.vperm8x32i(src,spec);

        public static Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
            => dinx.vperm8x32(src,spec);

        public static Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
            => dinx.vshuf32x8(a,spec);
 
    }
}