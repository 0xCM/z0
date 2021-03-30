//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public sealed class AsmTraverser : WfService<AsmTraverser>
    {
        FS.FolderPath StatementRoot
            => Db.TableDir<AsmApiStatement>();

        public void Traverse(Action<AsmApiStatement> receiver)
        {
            var files = StatementRoot.EnumerateFiles(FS.Extensions.Csv, true).Array();
            foreach(var file in files)
            {
                var flow = Wf.Running(FS.Msg.ParsingFile.Format(file));
                if(TextDocs.parse(file, out var doc))
                {
                    if(doc.Header.Labels.Length == AsmApiStatement.FieldCount)
                    {
                        var count = doc.RowCount;
                        var rows = doc.RowData.View;
                        for(var i=0; i<count; i++)
                        {
                            ref readonly var row = ref skip(rows,i);
                            if(AsmParser.parse(row, out var statement))
                                receiver(statement);
                        }
                        Wf.Ran(flow, FS.Msg.ParsedFile.Format(file));
                    }
                    else
                        Wf.Error($"Wrong field count of {doc.Header.Labels.Length}");
                }
                else
                    Wf.Error($"Could not parse {file.ToUri()}");
            }
        }
    }
}