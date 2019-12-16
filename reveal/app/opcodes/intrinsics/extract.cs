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

    partial class inxoc
    {
        public static ulong vcell_0_256x64u(Vector256<ulong> src)
            => vcell(src,0);

        public static ulong vcell_1_256x64u(Vector256<ulong> src)
            => vcell(src,1);

        public static ulong vcell_1_128x8u(Vector128<byte> src)
            => vcell(src,1);

        public static ulong vcell_2_256x64u(Vector256<ulong> src)
            => vcell(src,2);
    
        public static byte vcell_3_256x64u(Vector256<byte> src)
            => vcell(src,3);
    
        public static uint vcell_256x32u_1(Vector256<uint> src)
            => vcell(src,1);

        public static uint vcell_256x32u_2(Vector256<uint> src)
            => vcell(src,2);

        public static Vector128<byte> swap_hl(Vector128<byte> src)
            => ginx.vswaphl(src);

        [MethodImpl(Inline)]
        public static Vector128<ulong> hi_128x64u(Vector128<ulong> src)
            => ginx.vhi(src);

        public static Vector128<byte> hi_128x8u(Vector128<byte> src)
            => ginx.vhi(src);

        [MethodImpl(Inline)]
        public static Vector128<ulong> lo_128x64u(Vector128<ulong> src)
            => ginx.vlo(src);

        public static Vector128<byte> lo_128x8u(Vector128<byte> src)
            => ginx.vlo(src);
       

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


    }

}