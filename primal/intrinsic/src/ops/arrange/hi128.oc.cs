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
        public static Vec128<sbyte> hi128x8i(in Vec256<sbyte> src)         
            => ginx.hi(src);

        public static Vec128<byte> hi128x8u(in Vec256<byte> src)         
            => ginx.hi(src);

        public static Vec128<short> hi128x16i(in Vec256<short> src)         
            => ginx.hi(src);

        public static Vec128<ushort> hi128x16u(in Vec256<ushort> src)         
            => ginx.hi(src);

        public static Vec128<int> hi128x32i(in Vec256<int> src)         
            => ginx.hi(src);

        public static Vec128<uint> hi128x32u(in Vec256<uint> src)         
            => ginx.hi(src);

        public static Vec128<long> hi128x64i(in Vec256<long> src)         
            => ginx.hi(src);

        public static Vec128<ulong> hi128x64u(in Vec256<ulong> src)         
            => ginx.hi(src);
    }

}