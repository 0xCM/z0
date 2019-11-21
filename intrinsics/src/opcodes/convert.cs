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
        public static Vector128<byte> vmov128x8u(byte src)
            => dinx.vmov(n128,src);


        public static Vector128<ushort> vmov128x16u(ushort src)
            => dinx.vmov(n128, src);

        public static Vector128<uint> vmov128x32u(uint src)
            => dinx.vmov(n128,src);

        public static Vector128<ulong> vmov128x64u(ulong src)
            => dinx.vmov(n128,src);

        public static Vector128<double> vmov128x64u(double src)
            => dinx.vmov(n128,src);

        public static Vector256<byte> vmov256x8u(byte src)
            => dinx.vmov(n256,src);

        public static Vector256<ushort> vmov256x16u(ushort src)
            => dinx.vmov(n256, src);

        public static Vector256<uint> vmov256x32u(uint src)
            => dinx.vmov(n256,src);

        public static Vector256<ulong> vmov256x64u(ulong src)
            => dinx.vmov(n256,src);

        public static Vector256<double> vmov256x64u(double src)
            => dinx.vmov(n256,src);

        public static int bitspan_counts_4x8()
            => BitBlock.cells<N5,byte>();

        public static int bitspan_counts_8x8()
            => BitBlock.cells<N6,byte>();

        public static int bitspan_counts_4x16()
            => BitBlock.cells<N6,ushort>();

        public static Vector128<uint> mem8u_v128x32u(ref byte src, out Vector128<uint> dst)
            => dinx.vconvert(ref src, out dst);
            
        public static Vector128<uint> bs5x8u_v128x32u(in BitBlock<N5,byte> src, out Vector128<uint> dst)
            => dinx.vconvert(src, out dst);

        public static void vconvert_v256x16u_v2x256x64u(Vector256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(src, out lo, out hi);

        public static void vconvert_ymem16u_v2x256x64u(ref ushort src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(ref src, out lo, out hi);

        public static void vconvert_yspan16u_v2x256x64u(Block256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(src, out lo, out hi);

        public static Vector256<ulong> vconvert_xspan32u_v256x64u(Block128<uint> src, out Vector256<ulong> dst)        
            => dinx.vconvert(src, out dst);

        public static unsafe void vconvert_ymem32u_v2x256x64u(Block256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(src, out lo, out hi);

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