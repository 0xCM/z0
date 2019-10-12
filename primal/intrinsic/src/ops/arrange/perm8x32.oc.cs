//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class inxvoc
    {
        public static Vec256<int> vpermvar8x32_256x32i(in Vec256<int> src, in Vec256<int> spec)
            => dinx.vpermvar8x32(src,spec);

        public static Vec256<uint> vpermvar8x32_256x32u(in Vec256<uint> src, in Vec256<uint> spec)
            => dinx.vpermvar8x32(src,spec);

        public static Vec256<float> vpermvar8x32_256x32f(in Vec256<float> src, in Vec256<int> spec)
            => dinx.vpermvar8x32(src,spec);

        public static Vec256<byte> vpermvar32x8_256x8u(in Vec256<byte> a, in Vec256<byte> spec)
            => dinx.vpermvar32x8(a,spec);
 
    }
}