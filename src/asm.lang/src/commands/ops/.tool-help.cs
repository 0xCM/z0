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
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : Tool();
            var @base = ToolBase();
            var result = Outcome.Failure;
            if(tool.IsEmpty)
                return (false, "A tool has not been selected");

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