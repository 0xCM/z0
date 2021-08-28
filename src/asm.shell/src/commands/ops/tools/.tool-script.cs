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
            var tools = Ws.Tools();
            var tool = (ToolId)arg(args,0).Value;
            var script = tools.Script(tool, arg(args,1).Value);
            if(!script.Exists)
                return (false, FS.missing(script));
            else
                return OmniScript.Run(script, out var _);
        }
    }
}