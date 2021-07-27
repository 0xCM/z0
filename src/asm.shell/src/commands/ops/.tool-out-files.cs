//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
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
    }
}