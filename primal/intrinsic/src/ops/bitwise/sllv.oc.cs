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

    partial class inxoc
    {

        public static Vec128<int> vsllv_d128x32i(Vec128<int> src, Vec128<uint> offset)
            => dinx.vsllv(src,offset);

        public static Vec128<int> vsllv_g128x32i(Vec128<int> src, Vec128<uint> offset)
            => ginx.vsllv(src,offset);

        public static Vec128<uint> vsllv_d128x32u(Vec128<uint> src, Vec128<uint> offset)
            => dinx.vsllv(src,offset);

        public static Vec128<uint> vsllv_g128x32u(Vec128<uint> src, Vec128<uint> offset)
            => ginx.vsllv(src,offset);

        public static Vec128<long> vsllv_d128x64i(Vec128<long> src, Vec128<ulong> offset)
            => dinx.vsllv(src,offset);

        public static Vec128<long> vsllv_g128x64i(Vec128<long> src, Vec128<ulong> offset)
            => ginx.vsllv(src,offset);

        public static Vec128<ulong> vsllv_d128x64u(Vec128<ulong> src, Vec128<ulong> offset)
            => dinx.vsllv(src,offset);

        public static Vec128<ulong> vsllv_g128x64u(Vec128<ulong> src, Vec128<ulong> offset)
            => ginx.vsllv(src,offset);

        public static Vec256<int> vsllv_d256x32u(Vec256<int> src, Vec256<uint> offset)
            => dinx.vsllv(src,offset);

        public static Vec256<int> vsllv_g256x32u(Vec256<int> src, Vec256<uint> offset)
            => ginx.vsllv(src,offset);

        public static Vec256<uint> vsllv_d256x64i(Vec256<uint> src, Vec256<uint> offset)
            => dinx.vsllv(src,offset);

        public static Vec256<uint> vsllv_g256x64i(Vec256<uint> src, Vec256<uint> offset)
            => ginx.vsllv(src,offset);

        public static Vec256<long> vsllv_d256x64i(Vec256<long> src, Vec256<ulong> offset)
            => dinx.vsllv(src,offset);

        public static Vec256<long> vsllv_g256x64i(Vec256<long> src, Vec256<ulong> offset)
            => ginx.vsllv(src,offset);

        public static Vec256<ulong> vsllv_d256x64u(Vec256<ulong> src, Vec256<ulong> offset)
            => dinx.vsllv(src,offset);

        public static Vec256<ulong> vsllv_g256x64u(Vec256<ulong> src, Vec256<ulong> offset)
            => ginx.vsllv(src,offset);


    }

}