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

            var id = args[0].Value;
            var src = Workspace.InstInfo(id);
            if(!src.Exists)
                return (false, FS.missing(src));

            var info = default(InstructionInfo);
            var cols = Index<TableColumn>.Empty;
            var rows = list<TableRow>();
            var rowidx = z16;
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if((line.IsEmpty || line.StartsWith(Separator)) && !parsingrows)
                    continue;

                if(parsingrows && line.IsEmpty)
                {
                    foundtable = false;
                    parsingrows = false;
                    rowcount = 0;
                    continue;
                }

                var content = line.Content;
                if(parsingrows)
                {
                    var values  = content.SplitClean(ColSep);
                    var valcount = values.Length;

                    if(valcount != cols.Count)
                        Warn($"{valcount} != {cols.Count}");

                    if(valcount != 0)
                    {
                        Write(values.Join(Rejoin));
                        rowcount++;
                    }
                    continue;
                }

                if(foundtable && !parsingrows)
                {
                    var header = content.SplitClean(ColSep);
                    if(header.Length == 0)
                    {
                        Warn(string.Format("Expected header"));
                    }
                    else
                    {
                        cols = IntelSdm.columns(header);
                        var formatted = cols.Select(c => c.Format()).Join(Rejoin);
                        Write(formatted);
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

            return result;
        }
    }
}