//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".outfiles", "Output Files -> State")]
        public Outcome OutFiles(CmdArgs args)
        {
            var dir = OutWs().Subdir(arg(args,0));
            if(args.Length > 1)
                Files(dir.Files(arg(args,1).Value,true));
            else
                Files(dir.Files(true));
            return true;

            // .outfiles projects/builtins *.asm
        }
    }
}