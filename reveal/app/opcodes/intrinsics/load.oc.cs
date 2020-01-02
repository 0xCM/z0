//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    using static ginx;

    [OpCodeProvider]
    public static class vload
    {
        public static Vector128<byte> vgather_128x8u(Span<byte> src, Vector128<byte> vix)
            => vgather(n128, in head(src), vix);

        public static Vector128<ushort> vgather_128x16u(Span<ushort> src, Vector128<ushort> vix)
            => vgather(n128, in head(src), vix);

        public static Vector256<byte> vgather_256x8u(Span<byte> src, Vector256<byte> vix)
            => vgather(n256, in head(src), vix);

        public static Vector256<short> vgather_256x16i(Span<short> src, Vector256<short> vix)
            => vgather(n256, in head(src), vix);

        public static Vector256<ushort> vgather_256x16u(Span<ushort> src, Vector256<ushort> vix)
            => vgather(n256, in head(src), vix);

        public static Vector256<int> vgather_256x32i(Span<int> src, Vector256<int> vix)
            => vgather(n256, in head(src), vix);

        public static Vector128<ushort> vpackus_2x128x32(Vector128<uint> x, Vector128<uint> y)
            => dinx.vpackus(x,y);

        public static Vector128<ushort> vlo_256x16u(Vector256<ushort> x)
            => dinx.vlo(x);

        public static Vector256<uint> vconvert_128x16u_256x32u(Vector128<ushort> src)
            => dinx.vconvert(src,n256,z32);
    }
}