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
    using static Typed;

    partial struct AsciSymbols
    {
        public static AsciGrid grid<T>(Symbols<T> src, ushort width)
            where T : unmanaged
        {
            var symbols = src.View;
            var rows = symbols.Length;
            var size = rows*width + rows*2;
            var dst = alloc<byte>(size);
            var offset = 0u;
            for(var i=0; i<rows; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                offset += AsciSymbols.encode(w8, n5, symbol, offset, dst);
                seek(dst, offset++) = (byte)AsciControl.CR;
                seek(dst, offset++) = (byte)AsciControl.LF;
            }
            return new AsciGrid(AsciSymbols.seq(dst), (uint)rows, width);
        }

        [Op, Closures(UInt8k)]
        public static ReadOnlySpan<byte> row(in AsciGrid src, ushort index)
        {
            var offset = index*(src.RowWidth + 2);
            return slice(src.Rows, offset, src.RowWidth);
        }
    }
}