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

    [ApiHost]
    public readonly partial struct SdmRecords
    {
        [Op]
        public static uint fill(Table src, Span<OpCodeRecord> dst)
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
                        target.Expr = content;
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
                            target.LegacyModeExpr = content;
                        break;

                        case "64-bit Mode":
                            target.Mode64Expr = content;
                        break;

                        case "64/32 bit Mode Support":
                            target.Mode64x32Expr = content;
                        break;

                        case "CPUID Feature Flag":
                            target.CpuIdExpr = content;
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