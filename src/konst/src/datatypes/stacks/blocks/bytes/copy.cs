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

    readonly partial struct ByteBlocks
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
            u8(dst,0) = skip(src,0);
            u8(dst,1) = skip(src,1);
            u8(dst,2) = skip(src,2);
            u8(dst,3) = skip(src,3);
            u8(dst,4) = skip(src,4);
            u8(dst,5) = skip(src,5);
            u8(dst,6) = skip(src,6);
            u8(dst,7) = skip(src,7);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock16 copy(ReadOnlySpan<byte> src, ref ByteBlock16 dst)
        {
            var vSrc = SymBits.vload(w128, z.first(recover<byte,byte>(src)));
            SymBits.vstore(vSrc, ref u8r(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock32 copy(ReadOnlySpan<byte> src, ref ByteBlock32 dst)
        {
            var vSrc = SymBits.vload(w256, z.first(recover<byte,byte>(src)));
            SymBits.vstore(vSrc, ref u8r(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock64 copy(ReadOnlySpan<byte> src, ref ByteBlock64 dst)
        {
            var vSrc = SymBits.vload(w512, z.first(recover<byte,byte>(src)));
            SymBits.vstore(vSrc, ref u8r(dst));
            return ref dst;
        }
    }
}