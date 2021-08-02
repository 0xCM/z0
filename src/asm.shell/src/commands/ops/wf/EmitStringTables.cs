//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        Outcome EmitStringtables()
        {
            var result = Outcome.Success;
            var lists = Files(FS.List).View;
            var count = lists.Length;
            var delimiter = Chars.Comma;
            var csdst = Gen().Path("stringtables", FS.Cs);
            var rowdst = Gen().Path("stringtables", FS.Csv);
            var formatter = Tables.formatter<StringTableRow>(StringTableRow.RenderWidths);
            using var cswriter = csdst.Writer();
            using var rowwriter = rowdst.AsciWriter();
            rowwriter.WriteLine(formatter.FormatHeader());
            cswriter.WriteLine(string.Format("namespace {0}","Z0.LL.Data"));
            cswriter.WriteLine(Chars.LBrace);
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(lists,i);
                var name = text.right(path.FileName.WithoutExtension.Format(), "print-enums-");
                var table = StringTables.from(path,name,delimiter);
                cswriter.WriteLine(table.Format(4));
                for(var j=0u; j<table.EntryCount; j++)
                {
                    var content = table[j];
                    var row = StringTables.row(table,j);
                    rowwriter.WriteLine(formatter.Format(row));
                }

                Write(string.Format("{0}: Stringtable emitted", arrow(path.ToUri(),csdst.ToUri())));
            }
            cswriter.WriteLine(Chars.RBrace);

            Write(string.Format("{0}: Artifact generation complete", arrow("*", csdst.ToUri())));
            return result;
        }
    }
}