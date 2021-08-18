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

    partial class AsmCmdService
    {
        public Outcome EmitSdmOpCodeDetails()
        {
            var result = Outcome.Success;
            var src = DataSources.Datasets(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            var count = src.Length;
            var kinds = Symbols.index<SdmTableKind>();
            Index<SdmOpCodeDetail> storage = alloc<SdmOpCodeDetail>(4000);
            var buffer = storage.Edit;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var inpath = ref skip(src,i);
                var tables = SdmSvc.ReadInstructionTables(inpath);
                var id = inpath.FileName.WithoutExtension.Format();
                for(var j=0; j<tables.Length; j++)
                {
                    ref readonly var table = ref skip(tables,j);
                    var kind = (SdmTableKind)table.Kind;
                    ref readonly var symbol = ref kinds[kind];
                    Write(string.Format("{0,-16} | {1,-12} | {2}", id, symbol.Expr, table.Source));
                    if(kind == SdmTableKind.OpCodes)
                    {
                        var current = slice(buffer, counter);
                        counter += SdmRecords.fill(table, current);
                    }
                }
            }

            var rows = span(slice(buffer,0,counter).ToArray().Sort());

            for(var i=0u; i<rows.Length; i++)
                seek(rows,i).OpCodeId = i + 1;
            var outpath = TableWs().Table<SdmOpCodeDetail>();
            using var writer = outpath.UnicodeWriter();
            TableEmit(@readonly(rows), SdmOpCodeDetail.RenderWidths, writer, outpath);
            return result;
        }
    }
}