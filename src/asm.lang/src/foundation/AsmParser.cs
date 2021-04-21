//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;


    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct AsmParser
    {
        public static Outcome parse(string src, out AsmMnemonic dst)
        {
            dst = AsmCore.mnemonic(src);
            return true;
        }

        public static Outcome parse(string src, out AsmOpCodeExpr dst)
        {
            dst = AsmCore.opcode(src);
            return true;
        }

        [Op]
        public static Outcome parse(AsmMnemonic src, out AsmMnemonicCode dst)
            => ClrEnums.parse(src.Format(), out dst);

        [MethodImpl(Inline), Op]
        public static AsmStatementExpr statement(string src)
            => new AsmStatementExpr(src.Trim());

        [Op]
        public static Outcome parse(TextRow src, out AsmApiStatement dst)
        {
            var count = src.CellCount;
            var i=0;
            var cells = src.Cells.View;
            if(count == AsmApiStatement.FieldCount)
            {
                DataParser.parse(skip(cells, i++), out dst.BaseAddress);
                DataParser.parse(skip(cells, i++), out dst.IP);
                DataParser.parse(skip(cells, i++), out dst.BlockOffset);
                dst.Expression = AsmCore.statement(skip(cells,i++));
                AsmSyntax.sig(skip(cells, i++), out dst.Sig);
                dst.OpCode = AsmCore.opcode(skip(cells, i++));
                dst.Encoded = AsmBytes.hexcode(skip(cells, i++));
                if(!DataParser.parse(skip(cells, i++), out dst.OpUri))
                    return (false, $"Failed to parse uri text <{skip(cells,i)}>");

                return true;
            }
            else
            {
                dst = default;
                var msg = $"Wrong number of cells in row {src}";
                return (false,msg);
            }
        }
    }
}