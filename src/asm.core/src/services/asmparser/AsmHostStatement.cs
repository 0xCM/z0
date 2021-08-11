//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Concurrent;

    using static core;

    using R = AsmHostStatement;

    partial struct AsmParser
    {
        [Op]
        public static Outcome parse(in TextRow src, out R dst)
        {
            var result = Outcome.Success;
            var count = src.CellCount;
            var cells = src.Cells;
            dst = default;
            if(src.CellCount != R.FieldCount)
                return (false, AppMsg.FieldCountMismatch.Format(R.FieldCount, src.CellCount));

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

        public static Outcome<uint> parse(in TextGrid doc, ConcurrentBag<R> dst)
        {
            var counter = 0u;
            if(doc.Header.Labels.Length != R.FieldCount)
                return (false, AppMsg.FieldCountMismatch.Format(R.FieldCount, doc.Header.Labels.Length));

            var count = doc.RowCount;
            var rows = doc.RowData.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                var result = parse(row, out R statement);
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

        public static Outcome<uint> parse(in TextGrid doc, Span<R> dst)
        {
            var counter = 0u;
            if(doc.Header.Labels.Length != R.FieldCount)
                return (false, AppMsg.FieldCountMismatch.Format(R.FieldCount, doc.Header.Labels.Length));

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