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
        public static Vec128<sbyte> vhi_128x8i(in Vec256<sbyte> src)         
            => ginx.vhi(src);

        public static Vec128<byte> vhi_128x8u(in Vec256<byte> src)         
            => ginx.vhi(src);

        public static Vec128<short> vhi_128x16i(in Vec256<short> src)         
            => ginx.vhi(src);

        public static Vec128<ushort> vhi_128x16u(in Vec256<ushort> src)         
            => ginx.vhi(src);

        public static Vec128<int> vhi_128x32i(in Vec256<int> src)         
            => ginx.vhi(src);

        public static Vec128<uint> vhi_128x32u(in Vec256<uint> src)         
            => ginx.vhi(src);

        public static Vec128<long> vhi_128x64i(in Vec256<long> src)         
            => ginx.vhi(src);

        public static Vec128<ulong> vhi_128x64u(in Vec256<ulong> src)         
            => ginx.vhi(src);
    }

}