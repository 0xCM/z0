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

        public static Vector128<byte> vrotlx_n8(Vector128<byte> x)
            => dinx.vrotlx(x, n8);

        public static Vector128<byte> vrotlx_n16(Vector128<byte> x)
            => dinx.vrotlx(x, n16);

        public static Vector128<ulong> vrotlx_128(Vector128<ulong> x)
            => dinx.vrotlx(x, 8);

        public static Vector128<ulong> vrotlx_7(Vector128<ulong> x)
            => dinx.vrotlx(x, n7);

        public static Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector128<ushort> rotl_g128x16u(Vector128<ushort> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector128<uint> rotl_g128x32u(Vector128<uint> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector256<ushort> rotl_g256x16u(Vector256<ushort> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector256<uint> rotl_g256x32u(Vector256<uint> src, byte offset)
            => ginx.vrotl(src,offset);

        public static Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
            => ginx.vrotl(src,offset);

    }

}