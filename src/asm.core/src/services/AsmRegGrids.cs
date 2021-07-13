//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static RegClasses;

    [ApiComplete]
    public class AsmRegGrids : Service<AsmRegGrids>
    {
        AsmSymbols Symbols;

        GpRegGrid _GpGrid;

        public AsmRegGrids()
        {
            _GpGrid = GpRegGrid.Empty;
        }

        protected override void Initialized()
        {
            Symbols = Context.AsmSymbols();
        }

        const byte IndexWidth = 2;

        const byte SymbolWidth = 4;

        const byte HexWidth = 2;

        const byte BinWidth = 5;

        const byte EolWidth = 2;

        const byte RowWidth = IndexWidth + 1 + SymbolWidth + 1 + HexWidth + 1 + BinWidth;

        const byte ColCount = 4;

        const string RenderPattern = "{0,-2} {1,-4} {2,-2} {3,-5}";

        public uint Emit(in AsmRegGrid src, StreamWriter dst)
        {
            var count = src.RowCount;
            for(byte i=0; i<count; i++)
                dst.WriteLine(AsciSymbols.format(src.Row(i)));
            return (uint)count;
        }

        [Op, Closures(UInt8k)]
        public static AsciSequence asci<T>(W8 w, in Sym<T> symbol)
            where T : unmanaged
        {
            var seq = AsciSymbols.seq(w, n5, symbol);
            Require.equal(RowWidth, seq.Length);
            return seq;
        }

        [Op, Closures(UInt8k)]
        public static ReadOnlySpan<byte> row<T>(in AsmRegGrid<T> src, ushort index)
            where T : unmanaged
        {
            var offset = index*(RowWidth + 2);
            return slice(src.Rows,offset, RowWidth);
        }

        [Op, Closures(UInt8k)]
        public static ReadOnlySpan<byte> row(in AsmRegGrid src, ushort index)
        {
            var offset = index*(RowWidth + 2);
            return slice(src.Rows,offset, RowWidth);
        }

        public GpRegGrid GpGrid()
        {
            if(_GpGrid.IsEmpty)
            {
                _GpGrid = gp();
            }
            return _GpGrid;
        }

        [Op]
        public static GpRegGrid gp()
        {
            const byte Count = 4*16 + 4;
            const ushort size = Count*2;
            var buffer = alloc<RegOp>(Count);
            ref var dst = ref first(buffer);
            var @class = RegClassCode.GP;

            var w = RegWidthCode.W8;
            for(var i=0; i<16; i++)
                seek(dst,i) = AsmRegs.reg(w, @class, (RegIndexCode)i);

            w = RegWidthCode.W16;
            for(var i=0; i<16; i++)
                seek(dst,i) = AsmRegs.reg(w, @class, (RegIndexCode)i);

            w = RegWidthCode.W32;
            for(var i=0; i<16; i++)
                seek(dst,i) = AsmRegs.reg(w, @class, (RegIndexCode)i);

            w = RegWidthCode.W64;
            for(var i=0; i<16; i++)
                seek(dst,i) = AsmRegs.reg(w, @class, (RegIndexCode)i);

            w = RegWidthCode.W8;
            for(var i=0; i<4; i++)
                seek(dst,i) = AsmRegs.reg(w, @class, (RegIndexCode)i);

            return new GpRegGrid(buffer);
        }

        [Op]
        public AsmRegGrid Grid(GpClass gp, W8 w)
            => asci(Symbols.Gp8Regs());

        public AsmRegGrid Grid(GpClass gp, W8 w, bit hi)
            => asci(Symbols.Gp8Regs(hi));

        public AsmRegGrid Grid(GpClass gp, W16 w)
            => asci(Symbols.Gp16Regs());

        public AsmRegGrid Grid(GpClass gp, W32 w)
            => asci(Symbols.Gp32Regs());

        public AsmRegGrid Grid(GpClass gp, W64 w)
            => asci(Symbols.Gp64Regs());

        public AsmRegGrid Grid(XmmClass xmm)
            => asci(Symbols.XmmRegs());

        public AsmRegGrid Grid(YmmClass xmm)
            => asci(Symbols.YmmRegs());

        public AsmRegGrid Grid(ZmmClass xmm)
            => asci(Symbols.ZmmRegs());

        static AsmRegGrid<T> asci<T>(Symbols<T> src)
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
                offset += AsciSymbols.encode(w8, n5, symbol, offset, dst);
                seek(dst, offset++) = (byte)AsciControl.CR;
                seek(dst, offset++) = (byte)AsciControl.LF;
            }
            return new AsmRegGrid<T>(AsciSymbols.seq(dst), (byte)rows);
        }
    }
}