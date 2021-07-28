//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-script")]
        Outcome ToolScript(CmdArgs args)
        {
            var tools = ToolWs();
            var tool = (ToolId)arg(args,0).Value;
            var script = tools.Script(tool, arg(args,1).Value);
            if(!script.Exists)
                return (false, FS.missing(script));
            else
                return RunScript(script, out var _);
        }
    }
}