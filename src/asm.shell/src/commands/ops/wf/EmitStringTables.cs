//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using static core;

    partial class AsmCmdService
    {
        // .ws sources
        // .wsfiles datasets/llvm.tblgen.lists/*.list
        // .llvm-strings
        Outcome EmitLlvmStringTables()
        {
            var result = Outcome.Success;
            var lists = Files(FS.List).View;
            var count = lists.Length;
            var delimiter = Chars.Comma;
            var csdst = Gen().Path("llvm.stringtables", FS.Cs);
            var rowdst = Gen().Path("llvm.stringtables", FS.Csv);
            var formatter = Tables.formatter<StringTableRow>(StringTableRow.RenderWidths);
            using var cswriter = csdst.Writer();
            using var rowwriter = rowdst.AsciWriter();
            rowwriter.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(lists,i);
                var name = text.right(path.FileName.WithoutExtension.Format(), "print-enums-");
                var table = StringTables.from(path, name, delimiter);

                var spec = StringTables.specify("Z0.LL.Data", table);
                StringTables.emit(spec,cswriter);
                for(var j=0u; j<table.EntryCount; j++)
                {
                    var content = table[j];
                    var row = StringTables.row(table,j);
                    rowwriter.WriteLine(formatter.Format(row));
                }

                Write(string.Format("{0}: Stringtable emitted", arrow(path.ToUri(),csdst.ToUri())));
            }

            Write(string.Format("{0}: Artifact generation complete", arrow("*", csdst.ToUri())));
            return result;
        }

        Outcome EmitStringTable(StringTableSpec spec)
        {
            var result = Outcome.Success;
            var csdst = Gen().Path(spec.TableName, FS.Cs);
            var rowdst = Gen().Path(spec.TableName, FS.Csv);
            var formatter = Tables.formatter<StringTableRow>(StringTableRow.RenderWidths);
            using var cswriter = csdst.Writer();
            using var rowwriter = rowdst.AsciWriter();

            StringTables.emit(spec, cswriter);

            var entries = spec.Entries;
            var count = entries.Length;
            for(var j=0; j<count; j++)
            {
                var row = new StringTableRow();
                ref readonly var entry = ref skip(entries,j);
                row.EntryIndex = entry.Index;
                row.EntryName = entry.Content;
                row.TableName = spec.TableName;
                rowwriter.WriteLine(formatter.Format(row));
            }

            Write(string.Format("Emitted {0} and {1}", csdst.ToUri(), rowdst.ToUri()));

            return result;
        }
    }
}