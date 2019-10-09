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
        public static Vec128<sbyte> lo128x8i(in Vec256<sbyte> src)         
            => ginx.lo(src);

        public static Vec128<byte> lo128x8u(in Vec256<byte> src)         
            => ginx.lo(src);

        public static Vec128<short> lo128x16i(in Vec256<short> src)         
            => ginx.lo(src);

        public static Vec128<ushort> lo128x16u(in Vec256<ushort> src)         
            => ginx.lo(src);

        public static Vec128<int> lo128x32i(in Vec256<int> src)         
            => ginx.lo(src);

        public static Vec128<uint> lo128x32u(in Vec256<uint> src)         
            => ginx.lo(src);

        public static Vec128<long> lo128x64i(in Vec256<long> src)         
            => ginx.lo(src);

        public static Vec128<ulong> lo128x64u(in Vec256<ulong> src)         
            => ginx.lo(src);
    }

}