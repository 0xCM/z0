//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".tool-settings")]
        Outcome ToolSettings(CmdArgs args)
        {
            ToolId tool = arg(args,0).Value;
            var src = State.ToolBase().Logs(tool) + FS.file("config", FS.Log);
            if(!src.Exists)
                return (false,FS.missing(src));

            var settings = Tooling.settings(src);
            iter(settings, setting => Write(setting));
            return true;
        }
    }
}