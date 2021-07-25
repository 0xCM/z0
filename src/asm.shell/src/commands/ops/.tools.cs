//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using static WsNames;

    partial class AsmCmdService
    {
        [CmdOp(".tools")]
        Outcome DefineTools(CmdArgs args)
        {
            var ws = ToolWs();
            var subdirs = ws.Root.SubDirs();
            var counter = 0u;
            var formatter = Tables.formatter<ToolConfig>();
            var dst = ws.Root + FS.folder(".cmd") + FS.file("inventory", FS.Txt);
            using var writer = dst.AsciWriter();
            foreach(var dir in subdirs)
            {
                var configCmd = dir + FS.file(config, FS.Cmd);
                if(configCmd.Exists)
                {
                    var log =  dir + FS.folder(logs) + FS.file(config, FS.Log);
                    if(log.Exists)
                    {
                        var result = Tooling.parse(log.ReadText(), out var c);
                        if(result.Fail)
                        {
                            Write(result.Message);
                            continue;
                        }

                        var settings = formatter.Format(c,RecordFormatKind.KeyValuePairs);
                        var title = string.Format("# {0}", c.ToolId);
                        var sep = string.Format("# {0}", RP.PageBreak80);

                        Write(title,true);
                        Write(sep);
                        Write(settings);
                        writer.WriteLine(title);
                        writer.WriteLine(sep);
                        writer.WriteLine(settings);
                        counter++;
                    }
                }
            }

            Write(string.Format("{0} tools available", counter));
            return true;
        }
    }
}