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
        const byte StatementFieldCount = AsmApiStatement.FieldCount;

        public void Traverse(params Action<AsmApiStatement>[] receivers)
        {
            var dir = Db.TableDir<AsmApiStatement>();
            var files = dir.EnumerateFiles(FS.Csv, true).Array();
            foreach(var file in files)
            {
                var flow = Wf.Running(FS.Msg.ParsingFile.Format(file));
                if(TextDocs.parse(file, out var doc))
                {
                    if(doc.Header.Labels.Length == StatementFieldCount)
                    {
                        var count = doc.RowCount;
                        var rows = doc.RowData.View;
                        for(var i=0; i<count; i++)
                        {
                            ref readonly var row = ref skip(rows,i);
                            var result = AsmParser.parse(row, out var statement);
                            if(result)
                                root.iter(receivers, r => r(statement));
                            else
                                Wf.Error(Msg.CouldNotParseStatementRow.Format(row,result.Message));
                        }
                        Wf.Ran(flow, FS.Msg.ParsedFile.Format(file));
                    }
                    else
                        Wf.Error(Msg.UnexpectedFieldCount.Format(StatementFieldCount, doc.Header.Labels.Length));
                }
                else
                    Wf.Error(Msg.CouldNotParseDocument.Format(file));
            }
        }
    }
}