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

        public static void vblock_xor_128x8u_blocks(Block128<byte> xb, Block128<byte> yb, in Block128<byte> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x16u_blocks(Block128<ushort> xb, Block128<ushort> yb, in Block128<ushort> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x32u_blocks(Block128<uint> xb, Block128<uint> yb, in Block128<uint> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x64u_blocks(Block128<ulong> xb, Block128<ulong> yb, in Block128<ulong> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x8u_blocks(Block256<byte> xb, Block256<byte> yb, in Block256<byte> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x16u_blocks(Block256<ushort> xb, Block256<ushort> yb, in Block256<ushort> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x32u_blocks(Block256<uint> xb, Block256<uint> yb, in Block256<uint> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x64u_blocks(Block256<ulong> xb, Block256<ulong> yb, in Block256<ulong> zb)
            => ginx.vxor(xb,yb,zb);
    }
}