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
    using static zfunc;

    partial class inxoc
    {
        public static Vector128<byte> vsllx_128x8u(Vector128<byte> x)
            => ginx.vsllx(x, 15);

        public static Vector128<ushort> vsllx_128x16u(Vector128<ushort> x)
            => ginx.vsllx(x, 15);

        public static Vector128<uint> vsllx_128x32u(Vector128<uint> x)
            => ginx.vsllx(x, 15);

        public static Vector128<ulong> vsllx_128x64u(Vector128<ulong> x)
            => ginx.vsllx(x, 8);

        public static Vector256<byte> vsllx_256x8u(Vector256<byte> x)
            => ginx.vsllx(x, 13);

        public static Vector256<ulong> vsllx_256x64u(Vector256<ulong> x)
            => ginx.vsllx(x, 13);

        public static Vector128<byte> vsrlx_128x8u(Vector128<byte> x)
            => dinx.vsrlx(x, 8);

        public static Vector128<ulong> vsrlx_128x64u(Vector128<ulong> x)
            => ginx.vsrlx(x, 8);

        public static Vector256<ulong> vsrlx_256(Vector256<ulong> x)
            => ginx.vsrlx(x, 13);

        public static Vector128<ulong> vrotlx_128x64u(Vector128<ulong> x)
            => ginx.vrotlx(x, 14);

        public static Vector256<ulong> vrotlx_256x64u(Vector256<ulong> x)
            => ginx.vrotlx(x, 14);

        public static Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
            => ginx.vrotl(src,offset);
    }

}