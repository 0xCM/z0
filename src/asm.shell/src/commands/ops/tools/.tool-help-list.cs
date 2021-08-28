//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".tool-help-list")]
        Outcome ToolHelpList(CmdArgs args)
        {
            var result = Outcome.Success;
            var tool = (ToolId)arg(args,0).Value;
            var list = FS.file(arg(args,1).Value, FS.Txt);
            var @base = Ws.Tools();
            var path = @base.ToolDocs(tool) + list;
            if(path.Exists)
            {
                if(path.FileName.Contains("-bits"))
                {
                    var flags = Tooling.flags(path);
                    iter(flags, f => Write(f.Format()));
                }
                else
                {
                    var options = Tooling.options(path);
                    iter(options, f => Write(f.Format()));
                }
            }
            else
                return (false, FS.missing(path));

            return result;
        }
    }
}