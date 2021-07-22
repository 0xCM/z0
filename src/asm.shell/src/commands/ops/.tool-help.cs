//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-help")]
        Outcome ToolHelp(CmdArgs args)
        {
            var tool = (ToolId)arg(args,0).Value;
            var @base = State.ToolBase();
            var path = @base.Docs(tool) + FS.file(tool.Format(), FS.Help);
            if(path.Exists)
            {
                Write(path.ReadText());
                return true;
            }
            else
                return (false, FS.missing(path));
        }
    }
}