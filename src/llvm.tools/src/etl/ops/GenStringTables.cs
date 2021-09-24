//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;

    partial class EtlWorkflow
    {
        public Outcome GenStringTables()
        {
            const string TargetId = "llvm.stringtables";
            var result = Outcome.Success;
            var lists = Ws.Sources().Dataset(LlvmDatasetNames.TblgenLists).AllFiles.View;
            var count = lists.Length;
            var csdst = Ws.Gen().Path(TargetId, FS.Cs);
            var rowdst = Ws.Gen().Path(TargetId, FS.Csv);
            var formatter = Tables.formatter<StringTableRow>(StringTableRow.RenderWidths);
            using var cswriter = csdst.Writer();
            using var rowwriter = rowdst.AsciWriter();
            rowwriter.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(lists,i);
                var name = path.FileName.WithoutExtension.Format();
                var lines = path.ReadLines().View;
                var table = StringTables.create(lines, name, Chars.Comma);
                var spec = StringTables.specify("Z0." + TargetId, table);
                StringTables.csharp(spec, cswriter);
                for(var j=0u; j<table.EntryCount; j++)
                    rowwriter.WriteLine(formatter.Format(StringTables.row(table, j)));
                Write(string.Format("{0}: Stringtable emitted", Relations.arrow(path.ToUri(),csdst.ToUri())));
            }

            return result;
        }
    }
}