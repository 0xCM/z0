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

    partial struct Symbols
    {
        [Op, Closures(Closure)]
        public static AsciGrid ascigrid<K>(Symbols<K> src, ushort width)
            where K : unmanaged
        {
            var symbols = src.View;
            var rows = symbols.Length;
            var size = rows*width + rows*2;
            var dst = alloc<byte>(size);
            var offset = 0u;
            for(var i=0; i<rows; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                offset += asci(w8, n5, symbol.Expr, symbol.Kind, offset, dst);
                seek(dst, offset++) = (byte)AsciControl.CR;
                seek(dst, offset++) = (byte)AsciControl.LF;
            }
            return new AsciGrid(AsciSymbols.seq(dst), (uint)rows, width);
        }

        public static uint asci<T>(W8 w, N5 n, in SymExpr symbol, T kind, uint offset, Span<byte> dst)
            where T : unmanaged
        {
            const string RenderPattern = "{0,-2} {1,-4} {2,-2} {3,-5}";
            var index = u8(kind);
            var bits = BitRender.format(n, index);
            var hex = index.FormatHex(specifier:false);
            var desc = string.Format(RenderPattern,index, symbol, hex, bits);
            var width = desc.Length;
            AsciSymbols.encode(desc, slice(dst,offset));
            return (uint)width;
        }

        public static AsciSequence seq<T>(W8 w, N5 n, in SymExpr symbol, T kind)
            where T : unmanaged
        {
            const string RenderPattern = "{0,-2} {1,-4} {2,-2} {3,-5}";
            var index = u8(kind);
            var bits = BitRender.format(n, index);
            var hex = index.FormatHex(specifier:false);
            var desc = string.Format(RenderPattern,index, symbol, hex, bits);
            var width = desc.Length;
            var dst = alloc<byte>(width);
            AsciSymbols.encode(desc,dst);
            return AsciSymbols.seq(dst);
        }

    }
}