//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-docs")]
        Outcome ToolHelp(CmdArgs args)
        {
            var tool = (ToolId)arg(args,0).Value;
            var path = FS.FilePath.Empty;
            if(args.Length > 1)
                path = ToolWs().ToolDocs(tool) + FS.file(arg(args,1));
            else
                path = ToolWs().ToolDocs(tool) + FS.file(tool.Format(), FS.Help);

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