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
        public static Vector128<sbyte> vxor_n128x8i(Vector128<sbyte> x, Vector128<sbyte> y)
            => And(x,y);

        public static Vec128<sbyte> vxor_d128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
            => dinx.vxor(x,y);

        public static Vec128<sbyte> vxor_g128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
            => ginx.vxor(x,y);

        public static Vector128<byte> vxor_n128x8u(Vector128<byte> x, Vector128<byte> y)
            => And(x,y);

        public static Vec128<byte> vxor_d128x8u(Vec128<byte> x, Vec128<byte> y)
            => dinx.vxor(x,y);

        public static Vec128<byte> vxor_g128x8u(Vec128<byte> x, Vec128<byte> y)
            => ginx.vxor(x,y);

        public static Vector128<short> vxor_n128x16i(Vector128<short> x, Vector128<short> y)
            => And(x,y);

        public static Vec128<short> vxor_d128x16i(Vec128<short> x, Vec128<short> y)
            => dinx.vxor(x,y);

        public static Vec128<short> vxor_g128x16i(Vec128<short> x, Vec128<short> y)
            => ginx.vxor(x,y);

        public static Vector128<ushort> vxor_n128x16u(Vector128<ushort> x, Vector128<ushort> y)
            => And(x,y);

        public static Vec128<ushort> vxor_d128x16u(Vec128<ushort> x, Vec128<ushort> y)
            => dinx.vxor(x,y);

        public static Vec128<ushort> vxor_g128x16u(Vec128<ushort> x, Vec128<ushort> y)
            => ginx.vxor(x,y);

        public static Vector128<int> vxor_n128x32i(Vector128<int> x, Vector128<int> y)
            => And(x,y);

        public static Vec128<int> vxor_d128x32i(Vec128<int> x, Vec128<int> y)
            => dinx.vxor(x,y);

        public static Vec128<int> vxor_g128x32i(Vec128<int> x, Vec128<int> y)
            => ginx.vxor(x,y);

        public static Vector128<uint> vxor_n128x32u(Vector128<uint> x, Vector128<uint> y)
            => And(x,y);

        public static Vec128<uint> vxor_d128x32u(Vec128<uint> x, Vec128<uint> y)
            => dinx.vxor(x,y);

        public static Vec128<uint> vxor_g128x32u(Vec128<uint> x, Vec128<uint> y)
            => ginx.vxor(x,y);

        public static Vector128<long> vxor_n128x64i(Vector128<long> x, Vector128<long> y)
            => And(x,y);

        public static Vec128<long> vxor_d128x64i(Vec128<long> x, Vec128<long> y)
            => dinx.vxor(x,y);

        public static Vec128<long> vxor_g128x64i(Vec128<long> x, Vec128<long> y)
            => ginx.vxor(x,y);

        public static Vector128<ulong> vxor_n128x64u(Vector128<ulong> x, Vector128<ulong> y)
            => And(x,y);

        public static Vec128<ulong> vxor_d128x64u(Vec128<ulong> x, Vec128<ulong> y)
            => dinx.vxor(x,y);

        public static Vec128<ulong> vxor_g128x64u(Vec128<ulong> x, Vec128<ulong> y)
            => ginx.vxor(x,y);

        public static Vector128<float> vxor_n128x32f(Vector128<float> x, Vector128<float> y)
            => And(x,y);

        public static Vec128<float> vxor_d128x32f(Vec128<float> x, Vec128<float> y)
            => dfp.vxor(x,y);

        public static Vec128<float> vxor_g128x32f(Vec128<float> x, Vec128<float> y)
            => ginx.vxor(x,y);

        public static Vector128<double> vxor_n128x64f(Vector128<double> x, Vector128<double> y)
            => And(x,y);

        public static Vec128<double> vxor_d128x64f(Vec128<double> x, Vec128<double> y)
            => dfp.vxor(x,y);

        public static Vec128<double> vxor_g128x64f(Vec128<double> x, Vec128<double> y)
            => ginx.vxor(x,y);
 
         public static Vector256<sbyte> vxor_n256x8i(Vector256<sbyte> x, Vector256<sbyte> y)
            => And(x,y);

        public static Vec256<sbyte> vxor_d256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
            => dinx.vxor(x,y);

        public static Vec256<sbyte> vxor_g256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
            => ginx.vxor(x,y);

        public static Vector256<byte> vxor_n256x8u(Vector256<byte> x, Vector256<byte> y)
            => And(x,y);

        public static Vec256<byte> vxor_d256x8u(Vec256<byte> x, Vec256<byte> y)
            => dinx.vxor(x,y);

        public static Vec256<byte> vxor_g256x8u(Vec256<byte> x, Vec256<byte> y)
            => ginx.vxor(x,y);

        public static Vector256<short> vxor_n256x16i(Vector256<short> x, Vector256<short> y)
            => And(x,y);

        public static Vec256<short> vxor_d256x16i(Vec256<short> x, Vec256<short> y)
            => dinx.vxor(x,y);

        public static Vec256<short> vxor_g256x16i(Vec256<short> x, Vec256<short> y)
            => ginx.vxor(x,y);

        public static Vector256<ushort> vxor_n256x16u(Vector256<ushort> x, Vector256<ushort> y)
            => And(x,y);

        public static Vec256<ushort> vxor_d256x16u(Vec256<ushort> x, Vec256<ushort> y)
            => dinx.vxor(x,y);

        public static Vec256<ushort> vxor_g256x16u(Vec256<ushort> x, Vec256<ushort> y)
            => ginx.vxor(x,y);

        public static Vector256<int> vxor_n256x32i(Vector256<int> x, Vector256<int> y)
            => And(x,y);

        public static Vec256<int> vxor_d256x32i(Vec256<int> x, Vec256<int> y)
            => dinx.vxor(x,y);

        public static Vec256<int> vxor_g256x32i(Vec256<int> x, Vec256<int> y)
            => ginx.vxor(x,y);

        public static Vector256<uint> vxor_n256x32u(Vector256<uint> x, Vector256<uint> y)
            => And(x,y);

        public static Vec256<uint> vxor_d256x32u(Vec256<uint> x, Vec256<uint> y)
            => dinx.vxor(x,y);

        public static Vec256<uint> vxor_g256x32u(Vec256<uint> x, Vec256<uint> y)
            => ginx.vxor(x,y);

        public static Vector256<long> vxor_n256x64i(Vector256<long> x, Vector256<long> y)
            => And(x,y);

        public static Vec256<long> vxor_d256x64i(Vec256<long> x, Vec256<long> y)
            => dinx.vxor(x,y);

        public static Vec256<long> vxor_g256x64i(Vec256<long> x, Vec256<long> y)
            => ginx.vxor(x,y);

        public static Vector256<ulong> vxor_n256x64u(Vector256<ulong> x, Vector256<ulong> y)
            => And(x,y);

        public static Vec256<ulong> vxor_d256x64u(Vec256<ulong> x, Vec256<ulong> y)
            => dinx.vxor(x,y);

        public static Vec256<ulong> vxor_g256x64u(Vec256<ulong> x, Vec256<ulong> y)
            => ginx.vxor(x,y);

        public static Vector256<float> vxor_n256x32f(Vector256<float> x, Vector256<float> y)
            => And(x,y);

        public static Vec256<float> vxor_d256x32f(Vec256<float> x, Vec256<float> y)
            => dfp.vxor(x,y);

        public static Vec256<float> vxor_g256x32f(Vec256<float> x, Vec256<float> y)
            => ginx.vxor(x,y);

        public static Vector256<double> vxor_n256x64f(Vector256<double> x, Vector256<double> y)
            => And(x,y);

        public static Vec256<double> vxor_d256x64f(Vec256<double> x, Vec256<double> y)
            => dfp.vxor(x,y);

        public static Vec256<double> vxor_g256x64f(Vec256<double> x, Vec256<double> y)
            => ginx.vxor(x,y);
    }
}