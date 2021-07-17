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

    using S = Symbols;

    [ApiComplete]
    public class AsmRegGrids : Service<AsmRegGrids>
    {
        AsmSymbols Symbols;

        GpRegGrid _GpGrid;

        Index<char> _Buffer;

        public AsmRegGrids()
        {
            _GpGrid = GpRegGrid.Empty;
            _Buffer = alloc<char>(256);
        }

        protected override void Initialized()
        {
            Symbols = Context.AsmSymbols();
        }

        const byte IndexWidth = 2;

        const byte SymbolWidth = 4;

        const byte HexWidth = 2;

        const byte BinWidth = 5;

        const byte RowWidth = IndexWidth + 1 + SymbolWidth + 1 + HexWidth + 1 + BinWidth;

        Span<char> Buffer()
            => _Buffer.Clear();

        public uint Emit(in AsciGrid src, StreamWriter dst)
        {
            var count = src.RowCount;
            for(byte i=0; i<count; i++)
                dst.WriteLine(AsciSymbols.format(src.Row(i), Buffer()));
            return (uint)count;
        }

        public GpRegGrid GpGrid()
        {
            if(_GpGrid.IsEmpty)
                _GpGrid = gp();
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

        public AsciGrid Grid(GpClass gp, W8 w)
            => S.grid(Symbols.Gp8Regs(), RowWidth);

        public AsciGrid Grid(GpClass gp, W8 w, bit hi)
            => S.grid(Symbols.Gp8Regs(hi), RowWidth);

        public AsciGrid Grid(GpClass gp, W16 w)
            => S.grid(Symbols.Gp16Regs(), RowWidth);

        public AsciGrid Grid(GpClass gp, W32 w)
            => S.grid(Symbols.Gp32Regs(), RowWidth);

        public AsciGrid Grid(GpClass gp, W64 w)
            => S.grid(Symbols.Gp64Regs(), RowWidth);

        public AsciGrid Grid(XmmClass xmm)
            => S.grid(Symbols.XmmRegs(), RowWidth);

        public AsciGrid Grid(YmmClass xmm)
            => S.grid(Symbols.YmmRegs(),RowWidth);

        public AsciGrid Grid(ZmmClass xmm)
            => S.grid(Symbols.ZmmRegs(), RowWidth);
    }
}