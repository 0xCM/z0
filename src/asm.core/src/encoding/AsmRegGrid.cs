//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;


    public readonly struct AsmRegGrids
    {
        const byte IndexWidth = 2;

        const byte SymbolWidth = 4;

        const byte HexWidth = 2;

        const byte BinWidth = 5;

        const byte EolWidth = 2;

        const byte RowWidth = IndexWidth + 1 + SymbolWidth + 1 + HexWidth + 1 + BinWidth;

        const byte ColCount = 4;

        const string RenderPattern = "{0,-2} {1,-4} {2,-2} {3,-5}";

        public static AsciSequence asci<T>(W8 w, in Sym<T> symbol)
            where T : unmanaged
        {
            var seq = AsciSymbols.seq(w, n5, symbol);
            Require.equal(RowWidth, seq.Length);
            return seq;
        }

        public static ReadOnlySpan<byte> row<T>(in AsmRegGrid<T> src, byte index)
            where T : unmanaged
        {
            var offset = index*(RowWidth + 2);
            return slice(src.Rows,offset, RowWidth);
        }


        public static AsmRegGrid<T> asci<T>(W8 w, Symbols<T> src)
            where T : unmanaged
        {
            var symbols = src.View;
            var rows = symbols.Length;
            var size = rows*RowWidth + rows*2;
            var dst = alloc<byte>(size);
            var offset = 0u;
            for(var i=0; i<rows; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                offset += AsciSymbols.encode(w, n5, symbol,offset, dst);
                seek(dst,offset++) = (byte)AsciControl.CR;
                seek(dst,offset++) = (byte)AsciControl.LF;
            }
            return new AsmRegGrid<T>(AsciSymbols.seq(dst), (byte)rows);
        }
    }

    public readonly struct AsmRegGrid<K>
        where K : unmanaged
    {
        readonly AsciSequence _Data;

        public byte RowCount {get;}

        [MethodImpl(Inline)]
        public AsmRegGrid(AsciSequence src, byte rows)
        {
            _Data = src;
            RowCount = rows;
        }

        public ReadOnlySpan<byte> Rows
        {
            [MethodImpl(Inline)]
            get => _Data.View;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Row(byte index)
            => AsmRegGrids.row(this,index);

        public string Format()
            => _Data.Format();

        public override string ToString()
            => Format();
    }
}