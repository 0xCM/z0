//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static z;

    readonly partial struct CellBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref CellBlock2 copy(ReadOnlySpan<byte> src, ref CellBlock2 dst)
        {
            z.u8(dst,0) = skip(src,0);
            z.u8(dst,1) = skip(src,1);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CellBlock3 copy(ReadOnlySpan<byte> src, ref CellBlock3 dst)
        {
            z.u8(dst,0) = skip(src,0);
            z.u8(dst,1) = skip(src,1);
            z.u8(dst,2) = skip(src,2);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CellBlock4 copy(ReadOnlySpan<byte> src, ref CellBlock4 dst)
        {
            z.u8(dst,0) = skip(src,0);
            z.u8(dst,1) = skip(src,1);
            z.u8(dst,2) = skip(src,2);
            z.u8(dst,3) = skip(src,3);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CellBlock8 copy(ReadOnlySpan<byte> src, ref CellBlock8 dst)
        {
            dst = first(recover<byte,CellBlock8>(src));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CellBlock16 copy(ReadOnlySpan<byte> src, ref CellBlock16 dst)
        {
            var vSrc = z.vload(w128, first(src));
            z.vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CellBlock32 copy(ReadOnlySpan<byte> src, ref CellBlock32 dst)
        {
            var vSrc = z.vload(w256, first(src));
            z.vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CellBlock64 copy(ReadOnlySpan<byte> src, ref CellBlock64 dst)
        {
            var vSrc = z.vload(w512, first(src));
            z.vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CellBlock128 copy(ReadOnlySpan<byte> src, ref CellBlock128 dst)
        {
            copy(src, ref dst.Lo);
            copy(slice(src,64), ref dst.Hi);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void copy(in CellBlock64 src, ref CellBlock128 dst, byte offset)
        {
            seek(@as<CellBlock128,CellBlock64>(dst),offset) = src;
        }
    }
}