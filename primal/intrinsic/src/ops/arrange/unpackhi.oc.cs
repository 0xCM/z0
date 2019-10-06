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

        public static Vec128<sbyte> unpackhi_128x8i(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => ginx.unpackhi(x, y);

        public static Vec128<byte> unpackhi_128x8u(in Vec128<byte> x, in Vec128<byte> y)
            => ginx.unpackhi(x, y);

        public static Vec128<short> unpackhi_128x16i(in Vec128<short> x, in Vec128<short> y)
            => ginx.unpackhi(x, y);

        public static Vec128<ushort> unpackhi_128x16u(in Vec128<ushort> x, in Vec128<ushort> y)
            => ginx.unpackhi(x, y);

        public static Vec128<int> unpackhi_128x32i(in Vec128<int> x, in Vec128<int> y)
            => ginx.unpackhi(x, y);

        public static Vec128<uint> unpackhi_128x32u(in Vec128<uint> x, in Vec128<uint> y)
            => ginx.unpackhi(x, y);

        public static Vec128<long> unpackhi_128x64i(in Vec128<long> x, in Vec128<long> y)
            => ginx.unpackhi(x, y);

        public static Vec128<ulong> unpackhi_128x64u(in Vec128<ulong> x, in Vec128<ulong> y)
            => ginx.unpackhi(x, y);
        public static Vec256<sbyte> unpackhi_256x8i(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => ginx.unpackhi(x, y);

        public static Vec256<byte> unpackhi_256x8u(in Vec256<byte> x, in Vec256<byte> y)
            => ginx.unpackhi(x, y);

        public static Vec256<short> unpackhi_256x16i(in Vec256<short> x, in Vec256<short> y)
            => ginx.unpackhi(x, y);

        public static Vec256<ushort> unpackhi_256x16u(in Vec256<ushort> x, in Vec256<ushort> y)
            => ginx.unpackhi(x, y);

        public static Vec256<int> unpackhi_256x32i(in Vec256<int> x, in Vec256<int> y)
            => ginx.unpackhi(x, y);

        public static Vec256<uint> unpackhi_256x32u(in Vec256<uint> x, in Vec256<uint> y)
            => ginx.unpackhi(x, y);

        public static Vec256<long> unpackhi_256x64i(in Vec256<long> x, in Vec256<long> y)
            => ginx.unpackhi(x, y);

        public static Vec256<ulong> unpackhi_256x64u(in Vec256<ulong> x, in Vec256<ulong> y)
            => ginx.unpackhi(x, y);


    }

}