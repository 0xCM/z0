//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-out-dir", "Displays the path of a tool output directory")]
        Outcome ToolOut(CmdArgs args)
        {
            var result = ToolOutDir(args, out var dir);
            if(result)
                Write(dir);
            return result;
        }

        Outcome ToolOutDir(CmdArgs args, out FS.FolderPath dir)
        {
            dir = FS.FolderPath.Empty;
            if(args.Length == 0)
                return (false, ToolUnspecified.Format());

            var id = arg(args,0).Value;
            dir = OutRoot() + FS.folder(id);
            return true;
        }

        public FS.FolderPath ToolOutDir(ToolId tool)
            => Ws.Output().Subdir(tool.Format());

        FS.FolderPath ToolOutDir(CmdArgs args, ToolId tool)
            => args.Length > 0 ? OutRoot() + FS.folder(arg(args,0).Value) : ToolOutDir(tool);
    }
}