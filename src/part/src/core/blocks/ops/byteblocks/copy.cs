//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    partial class ByteBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref ByteBlock2 copy(ReadOnlySpan<byte> src, ref ByteBlock2 dst)
        {
            u16(dst,0) = core.first(uint16(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock3 copy(ReadOnlySpan<byte> src, ref ByteBlock3 dst)
        {
            dst = core.first(recover<byte,ByteBlock3>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock4 copy(ReadOnlySpan<byte> src, ref ByteBlock4 dst)
        {
            u32(dst,0) = core.first(uint32(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock8 copy(ReadOnlySpan<byte> src, ref ByteBlock8 dst)
        {
            u64(dst,0) = core.first(uint64(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock16 copy(ReadOnlySpan<byte> src, ref ByteBlock16 dst)
        {
            var vSrc = vload(w128, core.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock32 copy(ReadOnlySpan<byte> src, ref ByteBlock32 dst)
        {
            var vSrc = vload(w256, core.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock64 copy(ReadOnlySpan<byte> src, ref ByteBlock64 dst)
        {
            var vSrc = vload(w512, core.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock128 copy(ReadOnlySpan<byte> src, ref ByteBlock128 dst)
        {
            const ushort Block0 = 0*32;
            const ushort Block1 = 1*32;
            const ushort Block2 = 2*32;
            const ushort Block3 = 3*32;

            var v0 = vload(w256, skip(src,Block0));
            vstore(v0, ref seek(u8(dst), Block0));

            v0 = vload(w256, skip(src, Block1));
            vstore(v0, ref seek(u8(dst), Block1));

            v0 = vload(w256, skip(src, Block2));
            vstore(v0, ref seek(u8(dst), Block2));

            v0 = vload(w256, skip(src, Block3));
            vstore(v0, ref seek(u8(dst), Block3));

            return ref dst;
        }
    }
}