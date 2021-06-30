//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Windows;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
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

        [CmdOp(".datasheet")]
        Outcome ShowDatasheet(CmdArgs args)
        {
            const string TitleMarker = "# ";
            const string TableMarker = "## ";
            const string Separator = "------";
            const string TableTileFormat = "# Table {0}";
            const string Rejoin = " | ";

            var result = Outcome.Success;
            var foundtable = false;
            var parsingrows = false;
            var rowcount = 0;
            if(args.Length < 1)
                return (false, "Argument not supplied");

            var id = args[0].Value;
            var path = Workspace.Datasheet(id);
            if(!path.Exists)
                return (false, $"No such file {path.ToUri()}");

            using var reader = path.AsciLineReader();
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
                    var cols = content.SplitClean(Chars.Pipe);
                    if(cols.Length  != 0)
                    {
                        Row(cols.Join(Rejoin));
                        rowcount++;
                    }
                    continue;
                }

                if(foundtable && !parsingrows)
                {
                    var header = content.SplitClean(Chars.Pipe);
                    if(header.Length == 0)
                    {
                        Warn(string.Format("Expected header"));
                    }
                    else
                    {
                        Wf.Row(header.Join(Rejoin));
                        parsingrows = true;
                    }
                }

                if(content.StartsWith(TitleMarker))
                {
                    var title = content.Remove(TitleMarker);
                    Wf.Row(title);
                }
                else if(content.StartsWith(TableMarker))
                {
                    var name = content.Remove(TableMarker).Trim();
                    Wf.Row(string.Format(TableTileFormat, name));
                    foundtable = true;
                }

            }

            return result;
        }
    }
}