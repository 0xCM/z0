//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class inxvoc
    {
        public static byte vextract_128x8u_0(Vector128<byte> src)
            => ginx.vextract(src,n0);

        public static ulong vextract_128x64u_0(Vector128<ulong> src)
            => ginx.vextract(src,n0);

        public static ulong vextract_128x64u_1(Vector128<ulong> src)
            => ginx.vextract(src,n1);

        public static void vextract_128x64u_all(Vector128<ulong> src, out ulong x0, out ulong x1)
        {
            x0 = ginx.vextract(src,n0);
            x1 = ginx.vextract(src,n1);
        }

        public static void vextract_128x64u_all_2(Vector128<ulong> src, ref ulong dst)
        {
            dst = ginx.vextract(src, n0);
            Unsafe.Add(ref dst, 1) = ginx.vextract(src, n1);
        }

        public static void vextract_128x64u_all_3(Vector128<ulong> src, out ulong x0, out ulong x1)
        {
            x0 = ginx.vextract(src, 0);
            x1 = ginx.vextract(src, 1);
        }

        public static void vextract_128x64u_all_4(Vector128<ulong> src, ref ulong dst)
        {
            ginx.vstore(src, ref dst);
        }

        public static byte vextract_256x8u_0(Vector256<byte> src)
            => ginx.vextract(src,n0);

        public static byte vextract_256x8u_1(Vector256<byte> src)
            => ginx.vextract(src,n1);

        public static byte vextract_256x8u_2(Vector256<byte> src)
            => ginx.vextract(src,n2);

        public static uint vextract_256x32u_0(Vector256<uint> src)
            => ginx.vextract(src,n0);

        public static uint vextract_256x32u_1(Vector256<uint> src)
            => ginx.vextract(src,n1);

        public static ulong vextract_256x32u_2(Vector256<uint> src)
            => ginx.vextract(src,n2);

        public static uint vextract_256x32u_3(Vector256<uint> src)
            => ginx.vextract(src,n3);


        public static void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
            => dinx.vlo(src, out x0, out x1);

        public static ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
            => ref ginx.vlo(src, ref dst);

        public static void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
            => dinx.vlo(src, out x0, out x1);

        public static ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
            => ref ginx.vlo(src, ref dst);

        public static void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
            => ginx.vhi(src, out x0, out x1);

        public static ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
            => ref ginx.vhi(src, ref dst);

        public static ulong vextract_256x64u_0(Vector256<ulong> src)
            => ginx.vextract(src,n0);

        public static ulong vextract_256x64u_1(Vector256<ulong> src)
            => ginx.vextract(src,n1);

        public static ulong vextract_256x64u_2(Vector256<ulong> src)
            => ginx.vextract(src,n2);

        public static ulong vextract_256x64u_3(Vector256<ulong> src)
            => ginx.vextract(src,n3);

        public static Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
            => dinx.vshuffle(src,spec);

        public static Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
            => dinx.vshuffle(src,spec);

        public static Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
            => dinx.vshuffle(src,spec);

        public static Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
            => dinx.vshuffle(src,spec);


    }

}