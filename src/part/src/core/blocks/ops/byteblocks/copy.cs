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
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock3 copy(ReadOnlySpan<byte> src, ref ByteBlock3 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock4 copy(ReadOnlySpan<byte> src, ref ByteBlock4 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            u8(dst,3) = skip(src,3);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock8 copy(ReadOnlySpan<byte> src, ref ByteBlock8 dst)
        {
            dst = memory.first(recover<byte,ByteBlock8>(src));
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

        [MethodImpl(Inline), Op]
        public static void copy(in ByteBlock64 src, ref ByteBlock128 dst, byte offset)
            => seek(@as<ByteBlock128,ByteBlock64>(dst), offset) = src;
    }
}