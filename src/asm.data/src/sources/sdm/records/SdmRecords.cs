//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using M = SdmModels.EncodingSigs;
    using SQ = SymbolicQuery;

    [ApiHost]
    public readonly partial struct SdmRecords
    {
        [Op]
        public static uint fill(Table src, Span<SdmOpCodeDetail> dst)
        {
            var counter = 0u;
            var rows = src.Rows;
            var count = rows.Length;
            var cols = src.Cols;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(rows,i);
                ref var target = ref seek(dst,i);
                counter++;

                var cells = input.Cells;

                for(var k=0; k<cells.Length; k++)
                {
                    ref readonly var col = ref skip(cols,k);
                    ref readonly var cell = ref skip(cells,k);
                    var content = text.format(cell.Content).Trim();
                    switch(col.Name)
                    {
                        case "Opcode":
                        target.OpCode = content;
                        target.Rex = SQ.match(n3, content, M.Rex) >= 0;
                        target.RexW = SQ.match(n5,content, M.RexW) >= 0;
                        target.Vex = SQ.match(n4, content, M.Vex) >= 0;
                        target.Evex = SQ.match(n5,content, M.Evex) >= 0;
                        break;

                        case "Instruction":
                        target.Sig = content;
                        target.Mnemonic = text.ifempty(text.left(content, Chars.Space), content);
                        break;

                        case "Op / En":
                        case "Op/En":
                            target.EncXRef = content;
                        break;

                        case "Compat/Leg Mode":
                            target.LegacyMode = content;
                        break;

                        case "64-bit Mode":
                            target.Mode64 = content;
                        break;

                        case "64/32 bit Mode Support":
                            target.Mode64x32 = content;
                        break;

                        case "CPUID Feature Flag":
                            target.CpuId = content;
                        break;

                        case "Description":
                            target.Description = content;
                        break;
                    }
                }
            }
            return counter;
        }
    }
}