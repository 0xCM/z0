//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-out", "Displays the path of a tool output directory")]
        Outcome ToolOut(CmdArgs args)
        {
            var result = ToolOutDir(args, out var dir);
            if(result)
                Write(dir);
            return result;
        }

        [CmdOp(".tool-out-files", "Tool-specific Output Files -> State")]
        public Outcome ToolOutFiles(CmdArgs args)
        {
            var result = ToolOutDir(args, out var dir);
            if(result)
            {
                if(args.Length > 1)
                    Files(dir.Files(arg(args,1).Value,true));
                else
                    Files(dir.Files(true));
            }
            return result;
        }

        Outcome ToolOutDir(CmdArgs args, out FS.FolderPath dir)
        {
            dir = FS.FolderPath.Empty;
            if(args.Length == 0)
                return (false, ToolUnspecified.Format());

            var id = arg(args,0).Value;
            dir = State.OutDir() + FS.folder(id);
            return true;
        }

        FS.FolderPath ToolOutDir(CmdArgs args, ToolId tool)
            => args.Length > 0 ? State.OutDir() + FS.folder(arg(args,0).Value) : State.ToolOutDir(tool);
    }
}