//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class butterfly
    {

        public static byte butterfly_8x1(byte x)
            => gbits.butterfly(n1,x);

        public static Vector128<byte> vbutterfly_128x8x1(Vector128<byte> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<byte> vbutterfly_256x8x1(Vector256<byte> x)
            => gbits.vbutterfly(n1,x);

        public static ushort butterfly_16x1(ushort x)
            => gbits.butterfly(n1,x);

        public static Vector128<ushort> vbutterfly_128x16x1(Vector128<ushort> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<ushort> vbutterfly_256x16x1(Vector256<ushort> x)
            => gbits.vbutterfly(n1,x);

        public static uint butterfly_32x1(uint x)
            => gbits.butterfly(n1,x);

        public static Vector128<uint> vbutterfly_128x32x1(Vector128<uint> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<uint> vbutterfly_256x32x1(Vector256<uint> x)
            => gbits.vbutterfly(n1,x);

        public static ulong butterfly_64x1(ulong x)
            => gbits.butterfly(n1,x);

        public static Vector128<ulong> vbutterfly_128x64x1(Vector128<ulong> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<ulong> vbutterfly_256x64x1(Vector256<ulong> x)
            => gbits.vbutterfly(n1,x);

        public static byte butterfly_8x2(byte x)
            => gbits.butterfly(n2,x);

        public static Vector128<byte> vbutterfly_128x8x2(Vector128<byte> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<byte> vbutterfly_256x8x2(Vector256<byte> x)
            => gbits.vbutterfly(n2,x);

        public static ushort butterfly_16x2(ushort x)
            => gbits.butterfly(n2,x);

        public static Vector128<ushort> vbutterfly_128x16x2(Vector128<ushort> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<ushort> vbutterfly_256x16x2(Vector256<ushort> x)
            => gbits.vbutterfly(n2,x);

        public static uint butterfly_32x2(uint x)
            => Bits.butterfly(n2,x);

        public static Vector128<uint> vbutterfly_128x32x2(Vector128<uint> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<uint> vbutterfly_256x32x2(Vector256<uint> x)
            => gbits.vbutterfly(n2,x);

        public static ulong butterfly_64x2(ulong x)
            => gbits.butterfly(n2,x);

        public static Vector128<ulong> vbutterfly_128x64x2(Vector128<ulong> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<ulong> vbutterfly_256x64x2(Vector256<ulong> x)
            => gbits.vbutterfly(n2,x);

        public static ushort butterfly_16x4(ushort x)
            => Bits.butterfly(n4,x);

        public static Vector128<ushort> vbutterfly_128x16x4(Vector128<ushort> x)
            => gbits.vbutterfly(n4,x);

        public static Vector256<ushort> vbutterfly_256x16x4(Vector256<ushort> x)
            => gbits.vbutterfly(n4,x);

        public static ulong butterfly_32x4(uint x)
            => Bits.butterfly(n4,x);

        public static Vector128<uint> vbutterfly_128x32x4(Vector128<uint> x)
            => gbits.vbutterfly(n4,x);

        public static Vector256<uint> vbutterfly_256x32x4(Vector256<uint> x)
            => gbits.vbutterfly(n4,x);

        public static ulong butterfly_64x4(ulong x)
            => Bits.butterfly(n4,x);

        public static Vector128<ulong> vbutterfly_128x64x4(Vector128<ulong> x)
            => gbits.vbutterfly(n4,x);

        public static Vector256<ulong> vbutterfly_256x64x4(Vector256<ulong> x)
            => gbits.vbutterfly(n4,x);

        public static ulong butterfly_32x8(uint x)
            => gbits.butterfly(n8,x);

        public static Vector128<uint> vbutterfly_128x32x8(Vector128<uint> x)
            => gbits.vbutterfly(n8,x);

        public static Vector256<uint> vbutterfly_256x32x8(Vector256<uint> x)
            => gbits.vbutterfly(n8,x);

        public static ulong butterfly_64x8(ulong x)
            => gbits.butterfly(n8,x);

        public static Vector128<ulong> vbutterfly_128x64x8(Vector128<ulong> x)
            => gbits.vbutterfly(n8,x);

        public static Vector256<ulong> vbutterfly_256x64x8(Vector256<ulong> x)
            => gbits.vbutterfly(n8,x);

        public static ulong butterfly_64x16(ulong x)
            => gbits.butterfly(n16,x);

        public static Vector128<ulong> vbutterfly_128x64x16(Vector128<ulong> x)
            => gbits.vbutterfly(n16,x);

        public static Vector256<ulong> vbutterfly_256x64x16(Vector256<ulong> x)
            => gbits.vbutterfly(n16,x);

 
    }

}