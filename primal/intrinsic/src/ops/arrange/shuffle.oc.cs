//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class inxvoc
    {
        public static Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
            => dinx.vshuffle(src,spec);

        public static Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
            => dinx.vshuffle(src,spec);

        public static Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
            => dinx.vshuffle(src,spec);

        public static Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
            => dinx.vshuffle(src,spec);


    }

}