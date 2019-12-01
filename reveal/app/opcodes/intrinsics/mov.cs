//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    


    partial class inxoc
    {
        public static Vector128<byte> vmov_idx3_128x8u(byte src,  Vector128<byte> dst)
            => ginx.vmov(src, 3, dst);

        public static Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
            => ginx.vmov(src, 4, dst);

        public static Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
            => ginx.vmov(src, 2, dst);

        public static Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
            => ginx.vmov(src, 3, dst);

        public static Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
            => ginx.vmov(src, 4, dst);

        public static Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
            => ginx.vmov(src, 2, dst);

        public static Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b,Vector256<uint> dst)
            => ginx.vmov(b,4,ginx.vmov(a,2, dst));

        public static Vector128<byte> vmov128x8u(byte src)
            => ginx.vmov(n128,src);

        public static Vector128<ushort> vmov128x16u(ushort src)
            => ginx.vmov(n128, src);

        public static Vector128<uint> vmov128x32u(uint src)
            => ginx.vmov(n128,src);

        public static Vector128<ulong> vmov128x64u(ulong src)
            => ginx.vmov(n128,src);

        public static Vector128<double> vmov128x64u(double src)
            => ginx.vmov(n128,src);

        public static Vector256<byte> vmov256x8u(byte src)
            => ginx.vmov(n256,src);

        public static Vector256<ushort> vmov256x16u(ushort src)
            => ginx.vmov(n256, src);

        public static Vector256<uint> vmov256x32u(uint src)
            => ginx.vmov(n256,src);

        public static Vector256<ulong> vmov256x64u(ulong src)
            => ginx.vmov(n256,src);

        public static Vector256<double> vmov256x64u(double src)
            => ginx.vmov(n256,src);

        public static void vconvert_v256x16u_v2x256x64u(Vector256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(src, out lo, out hi);

        public static void vconvert_yspan16u_v2x256x64u(Block256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vmovblock(src, out lo, out hi);

        public static Vector256<ulong> vconvert_xspan32u_v256x64u(Block128<uint> src, out Vector256<ulong> dst)        
            => dinx.vmovblock(src, out dst);

        public static unsafe void vconvert_ymem32u_v2x256x64u(Block256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vmovblock(src, out lo, out hi);

        public static Vector256<byte> valignr256x4n(Vector256<byte> x, Vector256<byte> y)
            => dinx.valignr(x,y,n4);

        public static Vector256<byte> valignr256x4(Vector256<byte> x, Vector256<byte> y)
            => dinx.valignr(x,y,VAlignR.R4);

        public static Vector128<byte> valignr128x4n(Vector128<byte> x, Vector128<byte> y)
            => dinx.valignr(x,y,n4);

        public static Vector128<byte> valignr128x4(Vector128<byte> x, Vector128<byte> y)
            => dinx.valignr(x,y,VAlignR.R4);

        public static Vector128<byte> packus(Vector128<ushort> x,Vector128<ushort> y)
            => dinx.vpackus(x,y);

        public static Vector256<byte> packus(Vector256<ushort> x,Vector256<ushort> y)
            => dinx.vpackus(x,y);

    }
}