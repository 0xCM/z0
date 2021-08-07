//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static SdmModels;
    using static SdmRecords;

    partial class AsmCmdService
    {
        [CmdOp(".import-opcodes", "Imports the known instruction tables")]
        Outcome InstTableImport(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Sources().Dataset(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            var count = src.Length;
            var kinds = Symbols.index<SdmTableKind>();
            var buffer = span<OpCodeRecord>(4000);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var inpath = ref skip(src,i);
                var tables = SdmProcessor.ReadInstructionTables(inpath);
                var id = inpath.FileName.WithoutExtension.Format();
                for(var j=0; j<tables.Length; j++)
                {
                    ref readonly var table = ref skip(tables,j);
                    var kind = (SdmTableKind)table.Kind;
                    ref readonly var symbol = ref kinds[kind];
                    Write(string.Format("{0,-16} | {1,-12} | {2}", id, symbol.Expr, table.Source));
                    if(kind == SdmTableKind.OpCodes)
                    {
                        var current = slice(buffer,counter);
                        counter += SdmRecords.fill(table, current);
                    }
                }
            }

            var rows = slice(buffer,0,counter);
            for(var i=0u; i<rows.Length; i++)
                seek(rows,i).OpCodeId = i + 1;
            var outpath = TableWs().Table<OpCodeRecord>();
            using var writer = outpath.AsciWriter();
            TableEmit(@readonly(rows), OpCodeRecord.RenderWidths, writer, outpath);
            return result;
        }
    }
}