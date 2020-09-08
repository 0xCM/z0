//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    using static Konst;
    using static z;
    using F = Asm.AsmOpCodeField;

    public partial struct AsmTables
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> encode(in AsmSyntaxEncoding src)
            => MemoryMarshal.CreateReadOnlySpan(ref z.edit(src),1).Bytes();

        [Op, MethodImpl(Inline)]
        public static void parse(in AppResourceDoc specs, Span<AsmOpCodeTable> dst)
        {
            var fields = Enums.literals<F>();
            var src = span(specs.Rows);
            for(var i=0u; i<src.Length; i++)
               parse(skip(src,i), fields, ref seek(dst,i));
        }

        [Op, MethodImpl(Inline)]
        public static Span<AsmOpCodeTable> opcodes(in AppResourceDoc specs)
        {
            var dst = Spans.alloc<AsmOpCodeTable>(specs.Rows.Length);
            parse(specs, dst);
            return dst;
        }

        [Op]
        static ref readonly AsmOpCodeTable parse(in TextRow src, ReadOnlySpan<F> fields, ref AsmOpCodeTable dst)
        {
            ReadOnlySpan<string> cells = src.CellContent;
            var count = length(cells,fields);

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