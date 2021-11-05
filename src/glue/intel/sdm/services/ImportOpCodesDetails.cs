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
        public void ImportOpCodes()
        {
            var project = Project();
            var result = Outcome.Success;
            var details = ImportOpCodeDetails();
            var forms = EmitForms(details);
            EmitOpCodeStrings(details);
            var opcodes = SdmModels.opcodes(details).View;
            var count = opcodes.Length;
            var dst = project.Subdir("imports") + FS.file("sdm.opcodes", FS.Txt);
            using var writer = dst.AsciWriter();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(opcodes,i).Format());
        }

        Index<SdmOpCodeDetail> ImportOpCodeDetails()
        {
            var result = Outcome.Success;
            var dst =  Project().Subdir("imports");
            var dir = Sources() + FS.folder("sdm.instructions");
            var src = dir.Files(FS.Csv).ToReadOnlySpan();
            return ImportOpCodeDetails(src,dst);
        }

        Index<SdmOpCodeDetail> ImportOpCodeDetails(ReadOnlySpan<FS.FilePath> src, FS.FolderPath dir)
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
                    if(kind == SdmTableKind.OpCodes)
                    {
                        var current = slice(buffer, counter);
                        counter += SdmRecords.fill(table, current);
                    }
                }
            }

            var rows = slice(buffer,0,counter).ToArray().Sort();
            for(var i=0u; i<rows.Length; i++)
                seek(rows,i).OpCodeKey = i;

            var ws = Ws.Tables();
            var outpath = ws.TablePath<SdmOpCodeDetail>(dir);
            using var writer = outpath.UnicodeWriter();
            TableEmit(@readonly(rows), SdmOpCodeDetail.RenderWidths, writer, outpath);
            return rows;
        }
    }
}