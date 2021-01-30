//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static z;

    using F = AsmOpCodeField;

    partial struct AsmOpCodesLegacy
    {
        [Op]
        public static void parse(in AppResDoc specs, Span<AsmOpCodeRowLegacy> dst)
        {
            var fields = Enums.literals<F>();
            var src = specs.Rows.View;
            for(var i=0u; i<src.Length; i++)
               parse(skip(src,i), fields, ref seek(dst,i));
        }

        [Op]
        public static ref readonly AsmOpCodeRowLegacy parse(in TextRow src, ReadOnlySpan<F> fields, ref AsmOpCodeRowLegacy dst)
        {
            var cells = src.Cells.View;
            var count = root.length(cells, fields);

            var parser = new AsmFieldParser();
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(cells, i);
                ref readonly var field = ref skip(fields, i);
                switch(field)
                {
                    case F.Sequence:
                        parser.Parse(cell, out dst.Sequence);
                        break;
                    case F.Mnemonic:
                        parser.Parse(cell, out dst.Mnemonic);
                        break;
                    case F.OpCode:
                        parser.Parse(cell, out dst.OpCode);
                        break;
                    case F.Instruction:
                        parser.Parse(cell, out dst.Instruction);
                        break;
                    case F.M16:
                        parser.Parse(cell, out dst.M16);
                        break;
                    case F.M32:
                        parser.Parse(cell, out dst.M32);
                        break;
                    case F.M64:
                        parser.Parse(cell, out dst.M64);
                        break;
                    case F.CpuId:
                        parser.Parse(cell, out dst.CpuId);
                        break;
                    case F.CodeId:
                        parser.Parse(cell, out dst.CodeId);
                        break;
                }
            }

            return ref dst;
        }
    }
}