//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Windows;

    using static Root;
    using static core;
    using static Typed;

    partial class AsmCmdService
    {
        Outcome ShowEffective(CmdArgs args)
        {
            //var e1 = asm.effective(w8,)
            return true;
        }

        [CmdOp(".modrm")]
        Outcome ShowModRmTable(CmdArgs args)
        {
            var dst = span<char>(256*128);
            var count = AsmRender.ModRmBits(dst);
            var result = slice(dst,0,count);
            Wf.Row(result);
            return true;
        }

        [CmdOp(".rexbits")]
        Outcome ShowRexTable(CmdArgs args)
        {
            var bits = RexPrefix.Range();
            using var log = OpenShowLog("rexbits");
            var buffer = TextTools.buffer();
            AsmRender.RexTable(buffer);
            Show(buffer.Emit(), log);
            return true;
        }

        [CmdOp(".core")]
        Outcome ShowCurrentCore(CmdArgs args)
        {
            Wf.Row(string.Format("Cpu:{0}",Kernel32.GetCurrentProcessorNumber()));
            return true;
        }

        [CmdOp(".captured")]
        Outcome ShowCaptured(CmdArgs args)
        {
            var packs = Wf.ApiPacks();
            var catalog = Wf.ApiCatalogs();
            var available = packs.List();
            iter(available, a => Wf.Row(a.Root));
            var current = available.Last;
            var archive = packs.Archive(current.Root);
            var entries = catalog.LoadApiCatalog(archive.ContextRoot());
            var formatter = Tables.formatter<ApiCatalogEntry>();
            iter(entries, entry => Wf.Row(formatter.Format(entry)));
            return true;
        }

        [CmdOp(".respack-members")]
        Outcome ShowResPackMembers(CmdArgs args)
        {
            var provider = Wf.ApiResProvider();
            var accessors = provider.ResPackAccessors();
            var count = accessors.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var access = ref skip(accessors,i);
                var row = string.Format("{0,-12} | {1, -24} | {2}", access.Host.Part, access.Host.HostName, access.Member.DisplaySig());
                Wf.Row(row);
            }
            return true;
        }

        [CmdOp(".env")]
        Outcome ShowEnv(CmdArgs args)
        {
            var vars = SystemEnv.vars();
            iter(vars, v => Wf.Row(v));
            return true;
        }

        [CmdOp(".thread")]
        Outcome ShowThread(CmdArgs args)
        {
            var id = Kernel32.GetCurrentThreadId();
            Wf.Row(string.Format("ThreadId:{0}", id));
            return true;
        }

        [CmdOp(".xed-chips")]
        Outcome ShowXedChips(CmdArgs args)
        {
            var xed = Wf.IntelXed();
            var outcome = xed.LoadChipMap(out var map);
            if(outcome.Fail)
                Error(outcome.Message);
            else
            {
                var kinds = map.Kinds;
                var chips = map.Chips;
                foreach(var c in chips)
                {
                    var mapped = map[c];
                    var delimited = mapped.Delimit(Chars.Comma).Format();
                    Row(string.Format("{0}:{1}", c, delimited));
                }
            }
            return outcome;
        }

        [CmdOp(".inst-info")]
        Outcome ShowInstInfo(CmdArgs args)
        {
            const string TitleMarker = "# ";
            const string TableMarker = "## ";
            const string Separator = "------";
            const string TableTileFormat = "# {0}";
            const string Rejoin = " | ";
            const char ColSep = Chars.Pipe;

            var result = Outcome.Success;
            var foundtable = false;
            var parsingrows = false;
            var rowcount = 0;
            if(args.Length < 1)
                return (false, "Argument not supplied");

            var id = args[0].Value;
            var src = Workspace.InstInfo(id);
            if(!src.Exists)
                return (false, FS.missing(src));

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
                    var cols = content.SplitClean(ColSep);
                    if(cols.Length  != 0)
                    {
                        Row(cols.Join(Rejoin));
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
                        Row(header.Join(Rejoin));
                        parsingrows = true;
                    }
                }

                if(content.StartsWith(TitleMarker))
                {
                    var title = content.Remove(TitleMarker);
                    Row(title);
                }
                else if(content.StartsWith(TableMarker))
                {
                    var name = content.Remove(TableMarker).Trim();
                    Row(Chars.Space);
                    Row(string.Format(TableTileFormat, name));
                    Row(RP.PageBreak120);
                    foundtable = true;
                }
            }

            return result;
        }
    }
}