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

    partial class inxoc
    {
        public static Vector128<sbyte> vor_n128x8i(Vector128<sbyte> x, Vector128<sbyte> y)
            => And(x,y);

        public static Vec128<sbyte> vor_d128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
            => dinx.vor(x,y);

        public static Vec128<sbyte> vor_g128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
            => ginx.vor(x,y);

        public static Vector128<byte> vor_n128x8u(Vector128<byte> x, Vector128<byte> y)
            => And(x,y);

        public static Vec128<byte> vor_d128x8u(Vec128<byte> x, Vec128<byte> y)
            => dinx.vor(x,y);

        public static Vec128<byte> vor_g128x8u(Vec128<byte> x, Vec128<byte> y)
            => ginx.vor(x,y);

        public static Vector128<short> vor_n128x16i(Vector128<short> x, Vector128<short> y)
            => And(x,y);

        public static Vec128<short> vor_d128x16i(Vec128<short> x, Vec128<short> y)
            => dinx.vor(x,y);

        public static Vec128<short> vor_g128x16i(Vec128<short> x, Vec128<short> y)
            => ginx.vor(x,y);

        public static Vector128<ushort> vor_n128x16u(Vector128<ushort> x, Vector128<ushort> y)
            => And(x,y);

        public static Vec128<ushort> vor_d128x16u(Vec128<ushort> x, Vec128<ushort> y)
            => dinx.vor(x,y);

        public static Vec128<ushort> vor_g128x16u(Vec128<ushort> x, Vec128<ushort> y)
            => ginx.vor(x,y);

        public static Vector128<int> vor_n128x32i(Vector128<int> x, Vector128<int> y)
            => And(x,y);

        public static Vec128<int> vor_d128x32i(Vec128<int> x, Vec128<int> y)
            => dinx.vor(x,y);

        public static Vec128<int> vor_g128x32i(Vec128<int> x, Vec128<int> y)
            => ginx.vor(x,y);

        public static Vector128<uint> vor_n128x32u(Vector128<uint> x, Vector128<uint> y)
            => And(x,y);

        public static Vec128<uint> vor_d128x32u(Vec128<uint> x, Vec128<uint> y)
            => dinx.vor(x,y);

        public static Vec128<uint> vor_g128x32u(Vec128<uint> x, Vec128<uint> y)
            => ginx.vor(x,y);

        public static Vector128<long> vor_n128x64i(Vector128<long> x, Vector128<long> y)
            => And(x,y);

        public static Vec128<long> vor_d128x64i(Vec128<long> x, Vec128<long> y)
            => dinx.vor(x,y);

        public static Vec128<long> vor_g128x64i(Vec128<long> x, Vec128<long> y)
            => ginx.vor(x,y);

        public static Vector128<ulong> vor_n128x64u(Vector128<ulong> x, Vector128<ulong> y)
            => And(x,y);

        public static Vec128<ulong> vor_d128x64u(Vec128<ulong> x, Vec128<ulong> y)
            => dinx.vor(x,y);

        public static Vec128<ulong> vor_g128x64u(Vec128<ulong> x, Vec128<ulong> y)
            => ginx.vor(x,y);

        public static Vector128<float> vor_n128x32f(Vector128<float> x, Vector128<float> y)
            => And(x,y);

        public static Vec128<float> vor_d128x32f(Vec128<float> x, Vec128<float> y)
            => dinx.vor(x,y);

        public static Vec128<float> vor_g128x32f(Vec128<float> x, Vec128<float> y)
            => ginx.vor(x,y);

        public static Vector128<double> vor_n128x64f(Vector128<double> x, Vector128<double> y)
            => And(x,y);

        public static Vec128<double> vor_d128x64f(Vec128<double> x, Vec128<double> y)
            => dinx.vor(x,y);

        public static Vec128<double> vor_g128x64f(Vec128<double> x, Vec128<double> y)
            => ginx.vor(x,y);
 
         public static Vector256<sbyte> vor_n256x8i(Vector256<sbyte> x, Vector256<sbyte> y)
            => And(x,y);

        public static Vec256<sbyte> vor_d256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
            => dinx.vor(x,y);

        public static Vec256<sbyte> vor_g256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
            => ginx.vor(x,y);

        public static Vector256<byte> vor_n256x8u(Vector256<byte> x, Vector256<byte> y)
            => And(x,y);

        public static Vec256<byte> vor_d256x8u(Vec256<byte> x, Vec256<byte> y)
            => dinx.vor(x,y);

        public static Vec256<byte> vor_g256x8u(Vec256<byte> x, Vec256<byte> y)
            => ginx.vor(x,y);

        public static Vector256<short> vor_n256x16i(Vector256<short> x, Vector256<short> y)
            => And(x,y);

        public static Vec256<short> vor_d256x16i(Vec256<short> x, Vec256<short> y)
            => dinx.vor(x,y);

        public static Vec256<short> vor_g256x16i(Vec256<short> x, Vec256<short> y)
            => ginx.vor(x,y);

        public static Vector256<ushort> vor_n256x16u(Vector256<ushort> x, Vector256<ushort> y)
            => And(x,y);

        public static Vec256<ushort> vor_d256x16u(Vec256<ushort> x, Vec256<ushort> y)
            => dinx.vor(x,y);

        public static Vec256<ushort> vor_g256x16u(Vec256<ushort> x, Vec256<ushort> y)
            => ginx.vor(x,y);

        public static Vector256<int> vor_n256x32i(Vector256<int> x, Vector256<int> y)
            => And(x,y);

        public static Vec256<int> vor_d256x32i(Vec256<int> x, Vec256<int> y)
            => dinx.vor(x,y);

        public static Vec256<int> vor_g256x32i(Vec256<int> x, Vec256<int> y)
            => ginx.vor(x,y);

        public static Vector256<uint> vor_n256x32u(Vector256<uint> x, Vector256<uint> y)
            => And(x,y);

        public static Vec256<uint> vor_d256x32u(Vec256<uint> x, Vec256<uint> y)
            => dinx.vor(x,y);

        public static Vec256<uint> vor_g256x32u(Vec256<uint> x, Vec256<uint> y)
            => ginx.vor(x,y);

        public static Vector256<long> vor_n256x64i(Vector256<long> x, Vector256<long> y)
            => And(x,y);

        public static Vec256<long> vor_d256x64i(Vec256<long> x, Vec256<long> y)
            => dinx.vor(x,y);

        public static Vec256<long> vor_g256x64i(Vec256<long> x, Vec256<long> y)
            => ginx.vor(x,y);

        public static Vector256<ulong> vor_n256x64u(Vector256<ulong> x, Vector256<ulong> y)
            => And(x,y);

        public static Vec256<ulong> vor_d256x64u(Vec256<ulong> x, Vec256<ulong> y)
            => dinx.vor(x,y);

        public static Vec256<ulong> vor_g256x64u(Vec256<ulong> x, Vec256<ulong> y)
            => ginx.vor(x,y);

        public static Vector256<float> vor_n256x32f(Vector256<float> x, Vector256<float> y)
            => And(x,y);

        public static Vec256<float> vor_d256x32f(Vec256<float> x, Vec256<float> y)
            => dinx.vor(x,y);

        public static Vec256<float> vor_g256x32f(Vec256<float> x, Vec256<float> y)
            => ginx.vor(x,y);

        public static Vector256<double> vor_n256x64f(Vector256<double> x, Vector256<double> y)
            => And(x,y);

        public static Vec256<double> vor_d256x64f(Vec256<double> x, Vec256<double> y)
            => dinx.vor(x,y);

        public static Vec256<double> vor_g256x64f(Vec256<double> x, Vec256<double> y)
            => ginx.vor(x,y);
    }
}