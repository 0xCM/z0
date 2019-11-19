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

        public static void vconvert_v256x16u_v2x256x64u(Vector256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(src, out lo, out hi);

        public static void vconvert_ymem16u_v2x256x64u(ref ushort src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(ref src, out lo, out hi);

        public static void vconvert_yspan16u_v2x256x64u(Span256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => dinx.vconvert(src, out lo, out hi);

        public static Vector256<ulong> vconvert_xspan32u_v256x64u(Span128<uint> src, out Vector256<ulong> dst)        
            => dinx.vconvert(src, out dst);

        public static unsafe void vconvert_ymem32u_v2x256x64u(Span256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
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