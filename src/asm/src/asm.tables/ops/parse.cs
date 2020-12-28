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

    using F = AsmOpCodeField;

    partial struct AsmTables
    {
        [Op, MethodImpl(Inline)]
        public static Span<AsmOpCodeRow> opcodes(in AppResDoc specs)
        {
            var dst = Spans.alloc<AsmOpCodeRow>(specs.Rows.Length);
            parse(specs, dst);
            return dst;
        }

        [Op, MethodImpl(Inline)]
        public static void parse(in AppResDoc specs, Span<AsmOpCodeRow> dst)
        {
            var fields = Enums.literals<F>();
            var src = span(specs.Rows);
            for(var i=0u; i<src.Length; i++)
               parse(skip(src,i), fields, ref seek(dst,i));
        }

        [Op]
        static ref readonly AsmOpCodeRow parse(in TextRow src, ReadOnlySpan<AsmOpCodeField> fields, ref AsmOpCodeRow dst)
        {
            ReadOnlySpan<string> cells = src.CellContent;
            var count = z.length(cells,fields);

            var parser = new AsmFieldParser();
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(cells,i);
                ref readonly var field = ref skip(fields,i);
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