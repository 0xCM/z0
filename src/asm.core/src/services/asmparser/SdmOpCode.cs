//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static AppMsg;

    using R = SdmOpCodeRecord;

    partial struct AsmParser
    {
        public static Outcome<uint> parse(in TextGrid src, Span<R> dst)
        {
            var cells = src.Header.Labels.Count;
            if(cells != R.FieldCount)
                return (false, FieldCountMismatch.Format(R.FieldCount, cells));

            return parse(src.Rows, dst);
        }

        [Op]
        public static Outcome<uint> parse(ReadOnlySpan<TextRow> src, Span<R> dst)
        {
            var counter = 0u;
            var result = Outcome.Success;
            var count = min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                result = parse(row, out seek(dst,i));
                if(result.Fail)
                    return result;
            }
            return (true,counter);
        }
        [Op]
        public static Outcome parse(in TextRow src, out R dst)
        {
            var result = Outcome.Success;
            var count = src.CellCount;
            var cells = src.Cells;
            dst = default;
            if(src.CellCount != R.FieldCount)
                return (false, FieldCountMismatch.Format(R.FieldCount, src.CellCount));

            var i=0;

            result = DataParser.parse(skip(cells, i++), out dst.OpCodeId);
            if(result.Fail)
                return (false, ParseFailure.Format(nameof(dst.OpCodeId), skip(cells,i-1)));

            DataParser.block(skip(cells, i++), out dst.Mnemonic);
            DataParser.block(skip(cells, i++), out dst.OpCode);
            DataParser.block(skip(cells, i++), out dst.Sig);
            DataParser.block(skip(cells, i++), out dst.EncXRef);
            DataParser.block(skip(cells, i++), out dst.Mode64);
            DataParser.block(skip(cells, i++), out dst.LegacyMode);
            DataParser.block(skip(cells, i++), out dst.Mode64x32);
            DataParser.block(skip(cells, i++), out dst.CpuId);

            result = DataParser.parse(skip(cells, i++), out dst.Rex);
            if(result.Fail)
                return (false, ParseFailure.Format(nameof(dst.Rex), skip(cells,i-1)));

            result = DataParser.parse(skip(cells, i++), out dst.RexW);
            if(result.Fail)
                return (false, ParseFailure.Format(nameof(dst.RexW), skip(cells,i-1)));

            result = DataParser.parse(skip(cells, i++), out dst.Vex);
            if(result.Fail)
                return (false, ParseFailure.Format(nameof(dst.Vex), skip(cells,i-1)));

            result = DataParser.parse(skip(cells, i++), out dst.Evex);
            if(result.Fail)
                return (false, ParseFailure.Format(nameof(dst.Evex), skip(cells,i-1)));

            DataParser.block(skip(cells, i++), out dst.Description);
            return result;
        }
    }
}