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
        public static Vec128<sbyte> vflip_d128x8i(Vec128<sbyte> src)
            => dinx.vflip(src);

        public static Vec128<sbyte> vflip_g128x8i(Vec128<sbyte> src)
            => ginx.vflip(src);

        public static Vec128<byte> vflip_d128x8u(Vec128<byte> src)
            => dinx.vflip(src);

        public static Vec128<byte> vflip_g128x8u(Vec128<byte> src)
            => ginx.vflip(src);

        public static Vec128<short> vflip_d128x16i(Vec128<short> src)
            => dinx.vflip(src);

        public static Vec128<short> vflip_g128x16i(Vec128<short> src)
            => ginx.vflip(src);

        public static Vec128<ushort> vflip_d128x16u(Vec128<ushort> src)
            => dinx.vflip(src);

        public static Vec128<ushort> vflip_g128x16u(Vec128<ushort> src)
            => ginx.vflip(src);

        public static Vec128<int> vflip_d128x32i(Vec128<int> src)
            => dinx.vflip(src);

        public static Vec128<int> vflip_g128x32i(Vec128<int> src)
            => ginx.vflip(src);

        public static Vec128<uint> vflip_d128x32u(Vec128<uint> src)
            => dinx.vflip(src);

        public static Vec128<uint> vflip_g128x32u(Vec128<uint> src)
            => ginx.vflip(src);

        public static Vec128<long> vflip_d128x64i(Vec128<long> src)
            => dinx.vflip(src);

        public static Vec128<long> vflip_g128x64i(Vec128<long> src)
            => ginx.vflip(src);

        public static Vec128<ulong> vflip_d128x64u(Vec128<ulong> src)
            => dinx.vflip(src);

        public static Vec128<ulong> vflip_g128x64u(Vec128<ulong> src)
            => ginx.vflip(src);

        public static Vec256<sbyte> vflip_d256x8i(Vec256<sbyte> src)
            => dinx.vflip(src);

        public static Vec256<sbyte> vflip_g256x8i(Vec256<sbyte> src)
            => ginx.vflip(src);

        public static Vec256<byte> vflip_d256x8u(Vec256<byte> src)
            => dinx.vflip(src);

        public static Vec256<byte> vflip_g256x8u(Vec256<byte> src)
            => ginx.vflip(src);

        public static Vec256<short> vflip_d256x16i(Vec256<short> src)
            => dinx.vflip(src);

        public static Vec256<short> vflip_g256x16i(Vec256<short> src)
            => ginx.vflip(src);

        public static Vec256<ushort> vflip_d256x16u(Vec256<ushort> src)
            => dinx.vflip(src);

        public static Vec256<ushort> vflip_g256x16u(Vec256<ushort> src)
            => ginx.vflip(src);

        public static Vec256<int> vflip_d256x32i(Vec256<int> src)
            => dinx.vflip(src);

        public static Vec256<int> vflip_g256x32i(Vec256<int> src)
            => ginx.vflip(src);

        public static Vec256<uint> vflip_d256x32u(Vec256<uint> src)
            => dinx.vflip(src);

        public static Vec256<uint> vflip_g256x32u(Vec256<uint> src)
            => ginx.vflip(src);

        public static Vec256<long> vflip_d256x64i(Vec256<long> src)
            => dinx.vflip(src);

        public static Vec256<long> vflip_g256x64i(Vec256<long> src)
            => ginx.vflip(src);

        public static Vec256<ulong> vflip_d256x64u(Vec256<ulong> src)
            => dinx.vflip(src);
 
        public static Vec256<ulong> vflip_g256x64u(Vec256<ulong> src)
            => ginx.vflip(src);

    }

}