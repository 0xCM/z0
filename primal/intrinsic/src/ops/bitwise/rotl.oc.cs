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

        public static Vec256<ushort> vsll_2(in Vec128<byte> src, byte offset)
            => dinx.vsll_2(src,offset);

        public static Vec128<byte> vsll(in Vec128<byte> src, byte offset)
            => dinx.vsll(src,offset);


        public static Vec128<byte> rotl_128x8u(in Vec128<byte> src, byte offset)
            => ginx.rotl(src,offset);

        public static Vec128<ushort> rotl_128x16u(in Vec128<ushort> src, byte offset)
            => ginx.rotl(src,offset);

        public static Vec128<uint> rotl_128x32u(in Vec128<uint> src, byte offset)
            => ginx.rotl(src,offset);

        public static Vec128<ulong> rotl_128x64u(in Vec128<ulong> src, byte offset)
            => ginx.rotl(src,offset);

        public static Vec256<byte> rotl_256x8u(in Vec256<byte> src, byte offset)
            => ginx.rotl(src,offset);

        public static Vec256<ushort> rotl_256x16u(in Vec256<ushort> src, byte offset)
            => ginx.rotl(src,offset);

        public static Vec256<uint> rotl_256x32u(in Vec256<uint> src, byte offset)
            => ginx.rotl(src,offset);

        public static Vec256<ulong> rotl_256x64u(in Vec256<ulong> src, byte offset)
            => ginx.rotl(src,offset);

    }

}