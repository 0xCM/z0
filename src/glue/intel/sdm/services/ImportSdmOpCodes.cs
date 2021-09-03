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

    partial class IntelSdm
    {
        public Index<SdmOpCodeDetail> ImportSdmOpCodes()
        {
            var result = Outcome.Success;
            var src = Ws.Sources().Datasets(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            return ImportSdmOpCodes(src);
        }

        public Index<SdmOpCodeDetail> ImportSdmOpCodes(ReadOnlySpan<FS.FilePath> src)
        {
            var result = Outcome.Success;
            var count = src.Length;
            var kinds = Symbols.index<SdmTableKind>();
            Index<SdmOpCodeDetail> storage = alloc<SdmOpCodeDetail>(4000);
            var buffer = storage.Edit;
            var counter = 0u;
            var _tables = list<Table>();
            for(var i=0; i<count; i++)
            {
                ref readonly var inpath = ref skip(src,i);
                var tables = ReadCsvTables(inpath);
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

            var rows = slice(buffer,0,counter).ToArray().Sort();
            for(var i=0u; i<rows.Length; i++)
                seek(rows,i).OpCodeKey = i + 1;

            var ws = Ws.Tables();
            var outpath = ws.Table<SdmOpCodeDetail>();
            using var writer = outpath.UnicodeWriter();
            TableEmit(@readonly(rows), SdmOpCodeDetail.RenderWidths, writer, outpath);
            return rows;
        }
    }
}