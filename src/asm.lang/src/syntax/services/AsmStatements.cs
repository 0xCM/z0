//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public sealed class AsmStatements : WfService<AsmStatements>
    {
        AsmSigs Sigs;

        protected override void OnInit()
        {
            Sigs = Wf.AsmSigs();
        }

        public Outcome Parse(TextRow src, out AsmApiStatement dst)
        {
            var count = src.CellCount;
            var i=0;
            var cells = src.Cells.View;
            if(count == AsmApiStatement.FieldCount)
            {
                Tables.parse(skip(cells, i++), out dst.BlockOffset);
                dst.Expression = asm.statement(skip(cells,i++));
                AsmSyntax.sig(skip(cells, i++), out dst.Sig);
                dst.OpCode = asm.opcode(skip(cells, i++));
                dst.Encoded = AsmBytes.hexcode(skip(cells, i++));
                Tables.parse(skip(cells, i), out dst.BaseAddress);
                Tables.parse(skip(cells, i), out dst.IP);
                Tables.parse(skip(cells, i), out dst.OpUri);
                return true;
            }
            else
            {
                dst = default;
                var msg = $"Wrong number of cells in row {src}";
                Wf.Error(msg);
                return (false,msg);
            }
        }

        FS.FolderPath StatementRoot
            => Db.TableDir<AsmApiStatement>();

        public void Load(Action<AsmApiStatement> receiver)
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
                            if(Parse(row, out var statement))
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