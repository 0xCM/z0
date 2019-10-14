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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;


    partial class inxvoc
    {
        public static Vec128<byte> ones_128x8u()
            => Vec128Pattern.ones<byte>();

        public static Vec128<ulong> ones_128x64u()
            => Vec128Pattern.ones<ulong>();

        public static Vec256<byte> ones_256x8u()
            => Vec256Pattern.ones<byte>();

        public static Vec256<ulong> ones_256x64u()
            => Vec256Pattern.ones<ulong>();

        public static Vec256<double> ones_256x64f()
            => Vec256Pattern.ones<double>();

    }

}