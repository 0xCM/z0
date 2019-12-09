//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    using static AsIn;

    public static class bitmaskoc
    {            
        public static Vector128<byte> makemask_128x8u(BitVector16 src)
            => dinx.vmakemask(src);

        public static Vector128<byte> makemask_128x8u_literal()
            => dinx.vmakemask(0xFCFC);

        public static Vector256<byte> makemask_256x8u(BitVector32 src)
            => dinx.vmakemask(src);

        public static Vector256<byte> makemask_256x8u_literal()
            => dinx.vmakemask(0xF0F0F0C0u);

        public static Vector128<byte> makemask_g128x8u(BitVector16 src)
            => ginx.vmakemask<byte>(src);

        public static Vector128<ushort> makemask_g128x16u(BitVector16 src)
            => ginx.vmakemask<ushort>(src);

        public static Vector256<uint> makemask_g256x32u(BitVector32 src)
            => ginx.vmakemask<uint>(src);


    }
}