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
            var src = LlvmPaths.ImportTable<DefRelations>();
            var records = LoadDefRelationNodes(src);
            // var src = LlvmEtl.LoadSourceRecords(EtlNames.Datasets.X86);
            // var distiller = new DefRelationDistiller();
            // var relations = distiller.DistillRelations(src);
            // var pathA = LlvmPaths.ImportTable("llvm.defs.relations.test");
            // TableEmit(relations, DefRelations.RenderWidths, pathA);

            // var hydrated = LoadDefRelations(pathA);
            // var pathB = LlvmPaths.ImportTable("llvm.defs.relations.test.loaded");
            // TableEmit(hydrated, DefRelations.RenderWidths, pathB);

            return result;
        }

        ReadOnlySpan<DefRelations> LoadDefRelationNodes(FS.FilePath src)
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
                    var ancestors = row[j++].Text;
                    if(empty(ancestors))
                    {

                    }
                    else if(ancestors.Contains("->"))
                    {

                    }
                    else
                    {

                    }

                    // result += Lineage.parse(row[j++], out record.Ancestors);
                    // dst.Add(record);
                }
            }
            return dst.ViewDeposited();
        }
    }
}