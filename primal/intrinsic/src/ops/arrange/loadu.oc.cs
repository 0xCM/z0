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
        public static Vec128<sbyte> loadu_d128x8i(in sbyte src)
            => dinx.vloadu128(in src);

        public static Vec128<sbyte> loadu_g128x8i(in sbyte src)
            => ginx.loadu128(in src);

        public static Vec128<byte> loadu_d128x8u(in byte src)
            => dinx.vloadu128(in src);

        public static Vec128<byte> loadu_g128(in byte src)
            => ginx.loadu128(in src);

        public static Vec128<short> loadu_d128x16i(in short src)
            => dinx.vloadu128(in src);

        public static Vec128<short> loadu_g128x16i(in short src)
            => ginx.loadu128(in src);

        public static Vec128<ushort> loadu_d128x16u(in ushort src)
            => dinx.vloadu128(in src);

        public static Vec128<ushort> loadu_g128x16u(in ushort src)
            => ginx.loadu128(in src);

        public static Vec128<int> loadu_d128x32i(in int src)
            => dinx.vloadu128(in src);

        public static Vec128<int> loadu_g128x32i(in int src)
            => ginx.loadu128(in src);

        public static Vec128<uint> loadu_d128x32u(in uint src)
            => dinx.vloadu128(in src);

        public static Vec128<uint> loadu_g128x32u(in uint src)
            => ginx.loadu128(in src);

        public static Vec128<long> loadu_d128x64i(in long src)
            => dinx.vloadu128(in src);

        public static Vec128<long> loadu_g128x64i(in long src)
            => ginx.loadu128(in src);

        public static Vec128<ulong> loadu_d128x64u(in ulong src)
            => dinx.vloadu128(in src);

        public static Vec128<ulong> loadu_g128x64u(in ulong src)
            => ginx.loadu128(in src);

        public static Vec256<sbyte> loadu_d256x8i(in sbyte src)
            => dinx.vloadu256(in src);

        public static Vec256<sbyte> loadu_g256x8i(in sbyte src)
            => ginx.loadu256(in src);

        public static Vec256<byte> loadu_d256x8u(in byte src)
            => dinx.vloadu256(in src);

        public static Vec256<byte> loadu_g256x8u(in byte src)
            => ginx.loadu256(in src);

        public static Vec256<short> loadu_d256x16i(in short src)
            => dinx.vloadu256(in src);

        public static Vec256<short> loadu_g256x16i(in short src)
            => ginx.loadu256(in src);

        public static Vec256<ushort> loadu_d256x16u(in ushort src)
            => dinx.vloadu256(in src);

        public static Vec256<ushort> loadu_g256x16u(in ushort src)
            => ginx.loadu256(in src);

        public static Vec256<int> loadu_d256x32i(in int src)
            => dinx.vloadu256(in src);

        public static Vec256<int> loadu_g256x32i(in int src)
            => ginx.loadu256(in src);

        public static Vec256<uint> loadu_d256x32u(in uint src)
            => dinx.vloadu256(in src);

        public static Vec256<uint> loadu_g256x32u(in uint src)
            => ginx.loadu256(in src);

        public static Vec256<long> loadu_d256x64i(in long src)
            => dinx.vloadu256(in src);

        public static Vec256<long> loadu_g256x64i(in long src)
            => ginx.loadu256(in src);

        public static Vec256<ulong> loadu_d256x64u(in ulong src)
            => dinx.vloadu256(in src);

        public static Vec256<ulong> loadu_g256x64u(in ulong src)
            => ginx.loadu256(in src);
    }
}