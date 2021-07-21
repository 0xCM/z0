//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-out-files", "Reads and broadcasts the file paths within a tool output directory")]
        public Outcome ToolOutFiles(CmdArgs args)
        {
            var result = ToolOutDir(args, out var dir);
            if(result)
            {
                if(Arg(args,1, out var pattern))
                    Files(dir.Files(pattern,true));
                else
                    Files(dir.Files(true));
            }
            return result;
        }
    }
}