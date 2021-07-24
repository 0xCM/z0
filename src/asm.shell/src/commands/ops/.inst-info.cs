//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static IntelSdm;

    partial class AsmCmdService
    {
        [CmdOp(".inst-info")]
        Outcome ShowInstInfo(CmdArgs args)
        {
            const string TitleMarker = "# ";
            const string TableMarker = "## ";
            const string Separator = "------";
            const string TableTileFormat = "# {0}";
            const string InstTitleFormat = "# Instruction {0}";
            const string Rejoin = " | ";
            const char ColSep = Chars.Pipe;

            var result = Outcome.Success;
            var foundtable = false;
            var parsingrows = false;
            var tablekind = TableKind.None;
            var rowcount = 0;
            if(args.Length < 1)
                return (false, "Argument not supplied");

            var id = TableId.define(arg(args,0).Value);
            var src = State.Tables().Path(AsmTableScopes.IntelSdm, id);
            if(!src.Exists)
                return (false, FS.missing(src));

            var info = default(InstructionInfo);
            var cols = Index<TableColumn>.Empty;
            var rows = list<TableRow>();
            var rowidx = z16;
            var table = TableBuilder.create();
            var tables = list<Table>();
            using var reader = src.LineReader(TextEncodingKind.Asci);
            while(reader.Next(out var line))
            {
                if((line.IsEmpty || line.StartsWith(Separator)) && !parsingrows)
                    continue;

                if(parsingrows && line.IsEmpty)
                {
                    table.IfNonEmpty(() => tables.Add(Pipe(table.Emit())));
                    foundtable = false;
                    parsingrows = false;
                    rowcount = 0;
                    continue;
                }

                var content = line.Content;
                if(parsingrows)
                {
                    var values = content.SplitClean(ColSep);
                    var valcount = values.Length;

                    if(valcount != cols.Count)
                        Warn($"{valcount} != {cols.Count}");

                    if(valcount != 0)
                    {
                        table.WithRow(values);
                        Write(values.Join(Rejoin));
                        rowcount++;
                    }
                    continue;
                }

                if(foundtable && !parsingrows)
                {
                    var labels =  content.SplitClean(ColSep);
                    if(labels.Length == 0)
                    {
                        Warn(string.Format("Expected header"));
                    }
                    else
                    {
                        cols = IntelSdm.columns(labels);
                        table.WithColumns(cols);
                        Write(text.intersperse(cols.Select(x => x.Format()), Chars.Pipe));
                        parsingrows = true;
                    }
                }

                if(content.StartsWith(TitleMarker))
                {
                    info = InstructionInfo.init(content.Remove(TitleMarker));
                    Write(string.Format(InstTitleFormat, info.Mnemonic.Format(MnemonicCase.Uppercase)));
                }
                else if(content.StartsWith(TableMarker))
                {
                    tablekind = TableKinds.from(content.Remove(TableMarker).Trim());
                    Write(Chars.Space);
                    Write(string.Format(TableTileFormat, tablekind));
                    Write(RP.PageBreak120);
                    foundtable = true;
                }
            }

            table.IfNonEmpty(() => tables.Add(Pipe(table.Emit())));

            return result;
        }
    }
}