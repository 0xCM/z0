//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;
    using static Typed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in AsciCode2 src)
            => Control.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in AsciCode4 src)
            => Control.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in AsciCode5 src)
            => Control.bytes(src).Slice(0,5);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in AsciCode8 src)
            => Control.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in AsciCode16 src)
        {                        
            var dst = ByteBlocks.u8s(ByteBlocks.alloc(n16));
            SymBits.vstore(src.Storage, ref head(dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in AsciCode32 src)
        {                        
            var dst = ByteBlocks.u8s(ByteBlocks.alloc(n32));
            SymBits.vstore(src.Storage, ref head(dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in AsciCode64 src)
        {                        
            var dst = ByteBlocks.u8s(ByteBlocks.alloc(n64));
            SymBits.vstore(src.Storage, ref head(dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void bytes(ASCI asci, ReadOnlySpan<char> src, Span<byte> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void bytes(ASCI asci, in char src, int count, ref byte dst)
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = (byte)skip(src,i);
        }
    }
}