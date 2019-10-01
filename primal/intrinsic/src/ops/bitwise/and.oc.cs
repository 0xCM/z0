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
        public static Vector128<sbyte> vand_n128x8i(Vector128<sbyte> x, Vector128<sbyte> y)
            => And(x,y);

        public static Vec128<sbyte> vand_d128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
            => dinx.vand(x,y);

        public static Vec128<sbyte> vand_g128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
            => ginx.vand(x,y);

        public static Vector128<byte> vand_n128x8u(Vector128<byte> x, Vector128<byte> y)
            => And(x,y);

        public static Vec128<byte> vand_d128x8u(Vec128<byte> x, Vec128<byte> y)
            => dinx.vand(x,y);

        public static Vec128<byte> vand_g128x8u(Vec128<byte> x, Vec128<byte> y)
            => ginx.vand(x,y);

        public static Vector128<short> vand_n128x16i(Vector128<short> x, Vector128<short> y)
            => And(x,y);

        public static Vec128<short> vand_d128x16i(Vec128<short> x, Vec128<short> y)
            => dinx.vand(x,y);

        public static Vec128<short> vand_g128x16i(Vec128<short> x, Vec128<short> y)
            => ginx.vand(x,y);

        public static Vector128<ushort> vand_n128x16u(Vector128<ushort> x, Vector128<ushort> y)
            => And(x,y);

        public static Vec128<ushort> vand_d128x16u(Vec128<ushort> x, Vec128<ushort> y)
            => dinx.vand(x,y);

        public static Vec128<ushort> vand_g128x16u(Vec128<ushort> x, Vec128<ushort> y)
            => ginx.vand(x,y);

        public static Vector128<int> vand_n128x32i(Vector128<int> x, Vector128<int> y)
            => And(x,y);

        public static Vec128<int> vand_d128x32i(Vec128<int> x, Vec128<int> y)
            => dinx.vand(x,y);

        public static Vec128<int> vand_g128x32i(Vec128<int> x, Vec128<int> y)
            => ginx.vand(x,y);

        public static Vector128<uint> vand_n128x32u(Vector128<uint> x, Vector128<uint> y)
            => And(x,y);

        public static Vec128<uint> vand_d128x32u(Vec128<uint> x, Vec128<uint> y)
            => dinx.vand(x,y);

        public static Vec128<uint> vand_g128x32u(Vec128<uint> x, Vec128<uint> y)
            => ginx.vand(x,y);

        public static Vector128<long> vand_n128x64i(Vector128<long> x, Vector128<long> y)
            => And(x,y);

        public static Vec128<long> vand_d128x64i(Vec128<long> x, Vec128<long> y)
            => dinx.vand(x,y);

        public static Vec128<long> vand_g128x64i(Vec128<long> x, Vec128<long> y)
            => ginx.vand(x,y);

        public static Vector128<ulong> vand_n128x64u(Vector128<ulong> x, Vector128<ulong> y)
            => And(x,y);

        public static Vec128<ulong> vand_d128x64u(Vec128<ulong> x, Vec128<ulong> y)
            => dinx.vand(x,y);

        public static Vec128<ulong> vand_g128x64u(Vec128<ulong> x, Vec128<ulong> y)
            => ginx.vand(x,y);

        public static Vector128<float> vand_n128x32f(Vector128<float> x, Vector128<float> y)
            => And(x,y);

 
        public static Vector256<sbyte> vand_n256x8i(Vector256<sbyte> x, Vector256<sbyte> y)
            => And(x,y);

        public static Vec256<sbyte> vand_d256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
            => dinx.vand(x,y);

        public static Vec256<sbyte> vand_g256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
            => ginx.vand(x,y);

        public static Vector256<byte> vand_n256x8u(Vector256<byte> x, Vector256<byte> y)
            => And(x,y);

        public static Vec256<byte> vand_d256x8u(Vec256<byte> x, Vec256<byte> y)
            => dinx.vand(x,y);

        public static Vec256<byte> vand_g256x8u(Vec256<byte> x, Vec256<byte> y)
            => ginx.vand(x,y);

        public static Vector256<short> vand_n256x16i(Vector256<short> x, Vector256<short> y)
            => And(x,y);

        public static Vec256<short> vand_d256x16i(Vec256<short> x, Vec256<short> y)
            => dinx.vand(x,y);

        public static Vec256<short> vand_g256x16i(Vec256<short> x, Vec256<short> y)
            => ginx.vand(x,y);

        public static Vector256<ushort> vand_n256x16u(Vector256<ushort> x, Vector256<ushort> y)
            => And(x,y);

        public static Vec256<ushort> vand_d256x16u(Vec256<ushort> x, Vec256<ushort> y)
            => dinx.vand(x,y);

        public static Vec256<ushort> vand_g256x16u(Vec256<ushort> x, Vec256<ushort> y)
            => ginx.vand(x,y);

        public static Vector256<int> vand_n256x32i(Vector256<int> x, Vector256<int> y)
            => And(x,y);

        public static Vec256<int> vand_d256x32i(Vec256<int> x, Vec256<int> y)
            => dinx.vand(x,y);

        public static Vec256<int> vand_g256x32i(Vec256<int> x, Vec256<int> y)
            => ginx.vand(x,y);

        public static Vector256<uint> vand_n256x32u(Vector256<uint> x, Vector256<uint> y)
            => And(x,y);

        public static Vec256<uint> vand_d256x32u(Vec256<uint> x, Vec256<uint> y)
            => dinx.vand(x,y);

        public static Vec256<uint> vand_g256x32u(Vec256<uint> x, Vec256<uint> y)
            => ginx.vand(x,y);

        public static Vector256<long> vand_n256x64i(Vector256<long> x, Vector256<long> y)
            => And(x,y);

        public static Vec256<long> vand_d256x64i(Vec256<long> x, Vec256<long> y)
            => dinx.vand(x,y);

        public static Vec256<long> vand_g256x64i(Vec256<long> x, Vec256<long> y)
            => ginx.vand(x,y);

        public static Vector256<ulong> vand_n256x64u(Vector256<ulong> x, Vector256<ulong> y)
            => And(x,y);

        public static Vec256<ulong> vand_d256x64u(Vec256<ulong> x, Vec256<ulong> y)
            => dinx.vand(x,y);

        public static Vec256<ulong> vand_g256x64u(Vec256<ulong> x, Vec256<ulong> y)
            => ginx.vand(x,y);
   }
}