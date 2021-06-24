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

    partial struct AsciSymbols
    {
        public static AsciSequence seq<T>(W8 w, N5 n, in Sym<T> symbol)
            where T : unmanaged
        {
            const string RenderPattern = "{0,-2} {1,-4} {2,-2} {3,-5}";
            var kind = symbol.Kind;
            var index = u8(kind);
            var bits = BitRender.format(n, index);
            var hex = index.FormatHex(specifier:false);
            var desc = string.Format(RenderPattern,index, symbol.Expr, hex, bits);
            var width = desc.Length;
            var dst = alloc<byte>(width);
            AsciSymbols.encode(desc,dst);
            return AsciSymbols.seq(dst);
        }

        public static uint encode<T>(W8 w, N5 n, in Sym<T> symbol, uint offset, Span<byte> dst)
            where T : unmanaged
        {
            const string RenderPattern = "{0,-2} {1,-4} {2,-2} {3,-5}";
            var kind = symbol.Kind;
            var index = u8(kind);
            var bits = BitRender.format(n, index);
            var hex = index.FormatHex(specifier:false);
            var desc = string.Format(RenderPattern,index, symbol.Expr, hex, bits);
            var width = desc.Length;
            AsciSymbols.encode(desc,slice(dst,offset));
            return (uint)width;
        }

        [MethodImpl(Inline), Op]
        public static AsciSequence seq(byte[] src)
            => new AsciSequence(src);

        [MethodImpl(Inline), Op]
        public static AsciSequence seq(string src)
        {
            var buffer = alloc<byte>(src.Length);
            var seq = new AsciSequence(buffer);
            return AsciSymbols.encode(src,seq);
        }

        [MethodImpl(Inline), Op]
        public static AsciSequence seq(string src, byte[] dst)
        {
            AsciSymbols.encode(src,dst);
            return seq(dst);
        }

        [MethodImpl(Inline)]
        public static AsciSequence<A> seq<A>(A content)
            where A : unmanaged, IByteSeq
                => new AsciSequence<A>(content);
    }
}