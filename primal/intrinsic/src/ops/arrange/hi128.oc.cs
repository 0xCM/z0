//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class inxvoc
    {
        public static Vector128<sbyte> vhi_128x8i(Vector256<sbyte> src)         
            => ginx.vhi(src);

        public static Vector128<byte> vhi_128x8u(Vector256<byte> src)         
            => ginx.vhi(src);

        public static Vector128<short> vhi_128x16i(Vector256<short> src)         
            => ginx.vhi(src);

        public static Vector128<ushort> vhi_128x16u(Vector256<ushort> src)         
            => ginx.vhi(src);

        public static Vector128<int> vhi_128x32i(Vector256<int> src)         
            => ginx.vhi(src);

        public static Vector128<uint> vhi_128x32u(Vector256<uint> src)         
            => ginx.vhi(src);

        public static Vector128<long> vhi_128x64i(Vector256<long> src)         
            => ginx.vhi(src);

        public static Vector128<ulong> vhi_128x64u(Vector256<ulong> src)         
            => ginx.vhi(src);
    }

}