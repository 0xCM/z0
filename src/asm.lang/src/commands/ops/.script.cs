//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".script")]
        public Outcome Script(CmdArgs args)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : Tool();
            var tools = ToolBase();
            if(tool.IsEmpty)
                return (false, NoToolSelected.Format());

            var script = tools.Script(tool, arg(args,1).Value);
            if(!script.Exists)
                return (false, FS.missing(script));

            return RunScript(script, out var _);
        }
    }
}