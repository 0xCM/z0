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
        public static Vec128<sbyte> vlo_128x8i(in Vec256<sbyte> src)         
            => ginx.vlo(src);

        public static Vec128<byte> vlo_128x8u(in Vec256<byte> src)         
            => ginx.vlo(src);

        public static Vec128<short> vlo_128x16i(in Vec256<short> src)         
            => ginx.vlo(src);

        public static Vec128<ushort> vlo_128x16u(in Vec256<ushort> src)         
            => ginx.vlo(src);

        public static Vec128<int> vlo_128x32i(in Vec256<int> src)         
            => ginx.vlo(src);

        public static Vec128<uint> vlo_128x32u(in Vec256<uint> src)         
            => ginx.vlo(src);

        public static Vec128<long> vlo_128x64i(in Vec256<long> src)         
            => ginx.vlo(src);

        public static Vec128<ulong> vlo_128x64u(in Vec256<ulong> src)         
            => ginx.vlo(src);
    }

}