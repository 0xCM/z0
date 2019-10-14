//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class inxvoc
    {
        public static Vec128<byte> vcmpeq_d128x8u(Vec128<byte> x, Vec128<byte> y)
            => dinx.vcmpeq(x,y);

        public static Vec128<byte> vcmpeq_g128x8u(Vec128<byte> x, Vec128<byte> y)
            => ginx.vcmpeq(x,y);

        public static Vec256<byte> vcmpeq_d256x8u(Vec256<byte> x, Vec256<byte> y)
            => dinx.vcmpeq(x,y);

        public static Vec256<byte> vcmpeq_g256x8u(Vec256<byte> x, Vec256<byte> y)
            => ginx.vcmpeq(x,y);

    }

}