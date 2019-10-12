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
        public static Vec128<byte> vshuffle_128x8u(in Vec128<byte> src, in Vec128<byte> spec)
            => dinx.vshuffle(src,spec);

        public static Vec128<sbyte> vshuffle_128x8i(in Vec128<sbyte> src, in Vec128<sbyte> spec)
            => dinx.vshuffle(src,spec);

        public static Vec256<byte> vshuffle_256x8u(in Vec256<byte> src, in Vec256<byte> spec)
            => dinx.vshuffle(src,spec);

        public static Vec256<sbyte> vshuffle_256x8i(in Vec256<sbyte> src, in Vec256<sbyte> spec)
            => dinx.vshuffle(src,spec);


    }

}