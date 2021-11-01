//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using records;

    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".relations")]
        Outcome RecordRelations(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = LlvmPaths.Table<DefRelations>();
            var records = LoadDefRelations(src);

            return result;
        }

        ReadOnlySpan<DefRelations> LoadDefRelations(FS.FilePath src)
        {
            var dst = list<DefRelations>();
            var format = TextDocFormat.Structured();
            format.SplitClean = false;
            var result = TextGrids.load(src, format, out var grid);
            if(result.Fail)
            {
                Error(result.Message);
            }
            else
            {
                var rows = grid.Rows;
                var count = grid.RowCount;
                for(var i=0; i<count; i++)
                {
                    var record = new DefRelations();
                    ref readonly var row = ref rows[i];
                    if(row.CellCount != DefRelations.FieldCount)
                    {
                        Error(Tables.FieldCountMismatch.Format(DefRelations.FieldCount, row.CellCount));
                        Write(row);
                        break;
                    }
                    var j=0;
                    result += DataParser.parse(row[j++].Text, out record.SourceLine);
                    result += DataParser.parse(row[j++].Text, out record.Name);
                    // var ancestors = row[j++].Text;
                    // if(empty(ancestors))
                    // {
                    //     record.Ancestors = Lineage.Empty;
                    // }
                    // else if(ancestors.Contains("->"))
                    // {
                    //     Lineage.parse(ancestors, out record.Ancestors);
                    // }
                    // else
                    // {
                    //     record.Ancestors = Lineage.node(ancestors);
                    // }

                    // dst.Add(record);
                    // Write(string.Format("{0} -> {1}", record.Name, record.Ancestors));
                }
            }
            return dst.ViewDeposited();
        }
    }
}