//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class ByteBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref ByteBlock2 copy(ReadOnlySpan<byte> src, ref ByteBlock2 dst)
        {
            u16(dst,0) = memory.first(uint16(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock3 copy(ReadOnlySpan<byte> src, ref ByteBlock3 dst)
        {
            dst = memory.first(recover<byte,ByteBlock3>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock4 copy(ReadOnlySpan<byte> src, ref ByteBlock4 dst)
        {
            u32(dst,0) = memory.first(uint32(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock8 copy(ReadOnlySpan<byte> src, ref ByteBlock8 dst)
        {
            u64(dst,0) = memory.first(uint64(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock16 copy(ReadOnlySpan<byte> src, ref ByteBlock16 dst)
        {
            var vSrc = vload(w128, memory.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock32 copy(ReadOnlySpan<byte> src, ref ByteBlock32 dst)
        {
            var vSrc = vload(w256, memory.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock64 copy(ReadOnlySpan<byte> src, ref ByteBlock64 dst)
        {
            var vSrc = vload(w512, memory.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock128 copy(ReadOnlySpan<byte> src, ref ByteBlock128 dst)
        {
            copy(src, ref dst.A);
            copy(slice(src,64), ref dst.B);
            return ref dst;
        }
    }
}