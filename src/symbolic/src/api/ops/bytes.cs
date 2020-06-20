//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;
    using static Typed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci2 src)
            => Root.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci4 src)
            => Root.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci5 src)
            => Root.bytes(src).Slice(0,5);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci8 src)
            => Root.bytes(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci16 src)
        {                        
            var dst = ByteBlocks.u8s(ByteBlocks.alloc(n16));
            SymBits.vstore(src.Storage, ref head(dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci32 src)
        {                        
            var dst = ByteBlocks.u8s(ByteBlocks.alloc(n32));
            SymBits.vstore(src.Storage, ref head(dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> bytes(in asci64 src)
        {                        
            var dst = ByteBlocks.u8s(ByteBlocks.alloc(n64));
            SymBits.vstore(src.Storage, ref head(dst));
            return dst;
        }
    }
}