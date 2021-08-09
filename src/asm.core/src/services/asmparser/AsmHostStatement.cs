//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Concurrent;

    using static core;

    partial struct AsmParser
    {
        [Op]
        public static Outcome parse(in TextRow src, out AsmHostStatement dst)
        {
            var result = Outcome.Success;
            var count = src.CellCount;
            var cells = src.Cells;
            dst = default;
            if(src.CellCount != AsmHostStatement.FieldCount)
                return (false, AppMsg.FieldCountMismatch.Format(AsmHostStatement.FieldCount, src.CellCount));

            var i=0;
            result = DataParser.parse(skip(cells, i++), out dst.BlockAddress);
            if(result.Fail)
                return result;

            result = DataParser.parse(skip(cells, i++), out dst.IP);
            if(result.Fail)
                return result;

            result = DataParser.parse(skip(cells, i++), out dst.BlockOffset);
            if(result.Fail)
                return result;

            dst.Expression = asm.expr(skip(cells, i++));
            dst.Encoded = AsmHexCode.parse(skip(cells, i++));
            result = sig(skip(cells, i++), out dst.Sig);
            if(result.Fail)
                return result;

            dst.OpCode = asm.opcode(skip(cells, i++));
            dst.Bitstring = dst.Encoded;

            result = DataParser.parse(skip(cells, i++), out dst.OpUri);
            if(result.Fail)
                return (false, AppMsg.UriParseFailure.Format(skip(cells,i-1)));

            return result;
        }


        public static Outcome<uint> parse(in TextGrid doc, ConcurrentBag<AsmHostStatement> dst)
        {
            const byte StatementFieldCount = AsmHostStatement.FieldCount;

            var counter = 0u;
            if(doc.Header.Labels.Length != StatementFieldCount)
                return (false, AppMsg.FieldCountMismatch.Format(StatementFieldCount, doc.Header.Labels.Length));

            var count = doc.RowCount;
            var rows = doc.RowData.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                var result = parse(row, out AsmHostStatement statement);
                if(result)
                {
                    dst.Add(statement);
                    counter++;
                }
                else
                    return result;
            }
            return counter;
        }

        public static Outcome<uint> parse(in TextGrid doc, Span<AsmHostStatement> dst)
        {
            const byte FieldCount = AsmHostStatement.FieldCount;

            var counter = 0u;
            if(doc.Header.Labels.Length != FieldCount)
                return (false, AppMsg.FieldCountMismatch.Format(FieldCount, doc.Header.Labels.Length));

            var count = (uint)min(doc.RowCount, dst.Length);
            var rows = doc.RowData.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows, i);
                var result = parse(row, out seek(dst, i));
                if(result.Fail)
                    return result;
            }
            return count;
        }
    }
}