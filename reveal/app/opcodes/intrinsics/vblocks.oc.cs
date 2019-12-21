//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    [OpCodeProvider]
    public static class vblocks
    {
     
        public static ReadOnlySpan<short> spanconvert(Span<short> src)
            => src;

        public static void vblock_xor_128x8u_blocks(ConstBlock128<byte> xb, ConstBlock128<byte> yb, in Block128<byte> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x16u_blocks(ConstBlock128<ushort> xb, ConstBlock128<ushort> yb, in Block128<ushort> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x32u_blocks(ConstBlock128<uint> xb, ConstBlock128<uint> yb, in Block128<uint> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x64u_blocks(ConstBlock128<ulong> xb, ConstBlock128<ulong> yb, in Block128<ulong> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x8u_blocks(ConstBlock256<byte> xb, ConstBlock256<byte> yb, in Block256<byte> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x16u_blocks(ConstBlock256<ushort> xb, ConstBlock256<ushort> yb, in Block256<ushort> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x32u_blocks(ConstBlock256<uint> xb, ConstBlock256<uint> yb, in Block256<uint> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x64u_blocks(ConstBlock256<ulong> xb, ConstBlock256<ulong> yb, in Block256<ulong> zb)
            => ginx.vxor(xb,yb,zb);
    }
}