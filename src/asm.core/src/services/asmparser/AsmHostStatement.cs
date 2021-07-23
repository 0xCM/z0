//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Root;
    using static core;
    using static Rules;
    using static Chars;

    using SQ = SymbolicQuery;
    using SP = SymbolicParse;
    using SR = SymbolicRender;

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
                return (false, $"Failed to parse uri text <{skip(cells,i)}>");

            return true;
        }
    }
}