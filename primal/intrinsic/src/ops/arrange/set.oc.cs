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
        public static Vec256<sbyte> vset_256x8i(in Vec128<sbyte> lo, in Vec128<sbyte> hi)
            => ginx.vset(lo,hi);

        public static Vec256<byte> vset_256x8u(in Vec128<byte> lo, in Vec128<byte> hi)
            => ginx.vset(lo,hi);

        public static Vec256<short> vset_256x16i(in Vec128<short> lo, in Vec128<short> hi)
            => ginx.vset(lo,hi);

        public static Vec256<ushort> vset_256x16u(in Vec128<ushort> lo, in Vec128<ushort> hi)
            => ginx.vset(lo,hi);

        public static Vec256<int> vset_256x32i(in Vec128<int> lo, in Vec128<int> hi)
            => ginx.vset(lo,hi);

        public static Vec256<uint> vset_256x32i(in Vec128<uint> lo, in Vec128<uint> hi)
            => ginx.vset(lo,hi);

        public static Vec256<long> vset_256x64i(in Vec128<long> lo, in Vec128<long> hi)
            => ginx.vset(lo,hi);

        public static Vec256<ulong> vset_256x64u(in Vec128<ulong> lo, in Vec128<ulong> hi)
            => ginx.vset(lo,hi);

        public static Vec256<float> vset_256x64f(in Vec128<float> lo, in Vec128<float> hi)
            => ginx.vset(lo,hi);

        public static Vec256<double> vset_256x64f(in Vec128<double> lo, in Vec128<double> hi)
            => ginx.vset(lo,hi);
    }
}