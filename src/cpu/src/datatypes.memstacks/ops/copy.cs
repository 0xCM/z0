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

    partial class MemBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref MemBlock2 copy(ReadOnlySpan<byte> src, ref MemBlock2 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref MemBlock3 copy(ReadOnlySpan<byte> src, ref MemBlock3 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref MemBlock4 copy(ReadOnlySpan<byte> src, ref MemBlock4 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            u8(dst,3) = skip(src,3);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref MemBlock8 copy(ReadOnlySpan<byte> src, ref MemBlock8 dst)
        {
            dst = first(recover<byte,MemBlock8>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref MemBlock16 copy(ReadOnlySpan<byte> src, ref MemBlock16 dst)
        {
            var vSrc = vload(w128, first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref MemBlock32 copy(ReadOnlySpan<byte> src, ref MemBlock32 dst)
        {
            var vSrc = vload(w256, first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref MemBlock64 copy(ReadOnlySpan<byte> src, ref MemBlock64 dst)
        {
            var vSrc = vload(w512, first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref MemBlock128 copy(ReadOnlySpan<byte> src, ref MemBlock128 dst)
        {
            copy(src, ref dst.A);
            copy(slice(src,64), ref dst.B);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void copy(in MemBlock64 src, ref MemBlock128 dst, byte offset)
        {
            seek(@as<MemBlock128,MemBlock64>(dst), offset) = src;
        }
    }
}