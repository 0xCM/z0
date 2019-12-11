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

        public static void vblock_xor_128x8u_refs(int partcount, int partwidth, in byte a, in byte b, ref byte z)
            => vblock.xor(n128, partcount, partwidth,in a, in b, ref z);

        public static void vblock_xor_128x8u_blocks(ConstBlock128<byte> xb, ConstBlock128<byte> yb, in Block128<byte> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x16u_refs(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
            => vblock.xor(n128, partcount, partwidth,in a, in b, ref z);

        public static void vblock_xor_128x16u_blocks(ConstBlock128<ushort> xb, ConstBlock128<ushort> yb, in Block128<ushort> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x32u_refs(int partcount, int partwidth, in uint a, in uint b, ref uint z)
            => vblock.xor(n128, partcount, partwidth,in a, in b, ref z);

        public static void vblock_xor_128x32u_blocks(ConstBlock128<uint> xb, ConstBlock128<uint> yb, in Block128<uint> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_128x64u_refs(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
            => vblock.xor(n128, partcount, partwidth,in a, in b, ref z);

        public static void vblock_xor_128x64u_blocks(ConstBlock128<ulong> xb, ConstBlock128<ulong> yb, in Block128<ulong> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x8u_refs(int partcount, int partwidth, in byte a, in byte b, ref byte z)
            => vblock.xor(n256, partcount, partwidth,in a, in b, ref z);

        public static void vblock_xor_256x8u_blocks(ConstBlock256<byte> xb, ConstBlock256<byte> yb, in Block256<byte> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x16u_refs(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
            => vblock.xor(n256, partcount,partwidth,in a, in b, ref z);

        public static void vblock_xor_256x16u_blocks(ConstBlock256<ushort> xb, ConstBlock256<ushort> yb, in Block256<ushort> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x32u_refs(int partcount, int partwidth, in uint a, in uint b, ref uint z)
            => vblock.xor(n256, partcount,partwidth,in a, in b, ref z);

        public static void vblock_xor_256x32u_blocks(ConstBlock256<uint> xb, ConstBlock256<uint> yb, in Block256<uint> zb)
            => ginx.vxor(xb,yb,zb);

        public static void vblock_xor_256x64u_refs(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
            => vblock.xor(n256, partcount,partwidth,in a, in b, ref z);

        public static void vblock_xor_256x64u_blocks(ConstBlock256<ulong> xb, ConstBlock256<ulong> yb, in Block256<ulong> zb)
            => ginx.vxor(xb,yb,zb);

    }
}