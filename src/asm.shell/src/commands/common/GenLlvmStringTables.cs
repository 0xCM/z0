//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using static core;

    using Z0.llvm;

    partial class AsmCmdService
    {
        Outcome GenLlvmStringTables()
        {
            const string TargetId = "llvm.stringtables";

            var result = Outcome.Success;
            var lists = DataSources.Dataset(LlvmDatasetNames.TblgenLists).AllFiles.View;
            var count = lists.Length;
            var delimiter = Chars.Comma;
            var csdst = Gen().Path(TargetId, FS.Cs);
            var rowdst = Gen().Path(TargetId, FS.Csv);
            var formatter = Tables.formatter<StringTableRow>(StringTableRow.RenderWidths);
            using var cswriter = csdst.Writer();
            using var rowwriter = rowdst.AsciWriter();
            rowwriter.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(lists,i);
                var name = path.FileName.WithoutExtension.Format();
                var lines = path.ReadLines().View;
                var table = StringTables.create(lines, name, delimiter);
                var spec = StringTables.specify("Z0." + TargetId, table);
                StringTables.gencode(spec,cswriter);
                for(var j=0u; j<table.EntryCount; j++)
                {
                    var content = table[j];
                    var row = StringTables.row(table,j);
                    rowwriter.WriteLine(formatter.Format(row));
                }

                Write(string.Format("{0}: Stringtable emitted", arrow(path.ToUri(),csdst.ToUri())));
            }

            return result;
        }
    }
}