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

    using static zfunc;

    partial class inxvoc
    {

        public static Vector128<int> vcmplt_128x32i(Vector128<int> x, Vector128<int> y)
            => dinx.vcmplt(x,y);

        public static Vector128<int> vcmplt_g128x32i(Vector128<int> x, Vector128<int> y)
            => ginx.vcmplt(x,y);

        public static Vector128<uint> vcmplt_128x32u(Vector128<uint> x, Vector128<uint> y)
            => dinx.vcmplt(x,y);

        public static Vector128<uint> vcmplt_g128x32u(Vector128<uint> x, Vector128<uint> y)
            => ginx.vcmplt(x,y);

        public static Vector128<long> vcmplt_128x64i(Vector128<long> x, Vector128<long> y)
            => dinx.vcmplt(x,y);

        public static Vector128<long> vcmplt_g128x64i(Vector128<long> x, Vector128<long> y)
            => ginx.vcmplt(x,y);

        public static Vector128<ulong> vcmplt_128x64u(Vector128<ulong> x, Vector128<ulong> y)
            => dinx.vcmplt(x,y);

        public static Vector128<ulong> vcmplt_g128x64u(Vector128<ulong> x, Vector128<ulong> y)
            => ginx.vcmplt(x,y);


        public static Vector256<byte> vcmplt_256x8u(Vector256<byte> x, Vector256<byte> y)
            => dinx.vcmplt(x,y);

        public static Vector256<byte> vcmplt_g256x8u(Vector256<byte> x, Vector256<byte> y)
            => ginx.vcmplt(x,y);

        public static Vector256<long> vcmplt_256x64i(Vector256<long> x, Vector256<long> y)
            => dinx.vcmplt(x,y);

        public static Vector256<long> vcmplt_g256x64i(Vector256<long> x, Vector256<long> y)
            => ginx.vcmplt(x,y);

        public static Vector256<ulong> vcmplt_256x64u(Vector256<ulong> x, Vector256<ulong> y)
            => dinx.vcmplt(x,y);

        public static Vector256<ulong> vcmplt_g256x64u(Vector256<ulong> x, Vector256<ulong> y)
            => ginx.vcmplt(x,y);

    }

}