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
        public static ref Block2 copy(ReadOnlySpan<byte> src, ref Block2 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Block3 copy(ReadOnlySpan<byte> src, ref Block3 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Block4 copy(ReadOnlySpan<byte> src, ref Block4 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            u8(dst,3) = skip(src,3);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Block8 copy(ReadOnlySpan<byte> src, ref Block8 dst)
        {
            dst = memory.first(recover<byte,Block8>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Block16 copy(ReadOnlySpan<byte> src, ref Block16 dst)
        {
            var vSrc = vload(w128, memory.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Block32 copy(ReadOnlySpan<byte> src, ref Block32 dst)
        {
            var vSrc = vload(w256, memory.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Block64 copy(ReadOnlySpan<byte> src, ref Block64 dst)
        {
            var vSrc = vload(w512, memory.first(src));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Block128 copy(ReadOnlySpan<byte> src, ref Block128 dst)
        {
            copy(src, ref dst.A);
            copy(slice(src,64), ref dst.B);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void copy(in Block64 src, ref Block128 dst, byte offset)
            => seek(@as<Block128,Block64>(dst), offset) = src;

    }
}