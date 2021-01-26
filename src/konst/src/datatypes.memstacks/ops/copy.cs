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

    partial class MemoryStacks
    {
        [MethodImpl(Inline), Op]
        public static ref StackBlock2 copy(ReadOnlySpan<byte> src, ref StackBlock2 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StackBlock3 copy(ReadOnlySpan<byte> src, ref StackBlock3 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StackBlock4 copy(ReadOnlySpan<byte> src, ref StackBlock4 dst)
        {
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            u8(dst,3) = skip(src,3);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StackBlock8 copy(ReadOnlySpan<byte> src, ref StackBlock8 dst)
        {
            dst = first(recover<byte,StackBlock8>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StackBlock16 copy(ReadOnlySpan<byte> src, ref StackBlock16 dst)
        {
            var vSrc = cpu.vload(w128, first(src));
            cpu.vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StackBlock32 copy(ReadOnlySpan<byte> src, ref StackBlock32 dst)
        {
            var vSrc = cpu.vload(w256, first(src));
            cpu.vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StackBlock64 copy(ReadOnlySpan<byte> src, ref StackBlock64 dst)
        {
            var vSrc = cpu.vload(w512, first(src));
            cpu.vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StackBlock128 copy(ReadOnlySpan<byte> src, ref StackBlock128 dst)
        {
            copy(src, ref dst.Lo);
            copy(slice(src,64), ref dst.Hi);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void copy(in StackBlock64 src, ref StackBlock128 dst, byte offset)
        {
            seek(@as<StackBlock128,StackBlock64>(dst),offset) = src;
        }
    }
}