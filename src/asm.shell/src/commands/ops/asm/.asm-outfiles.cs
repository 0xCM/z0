//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    partial class AsmCmdService
    {
        [CmdOp(".asm-outfiles")]
        Outcome AsmOutfiles(CmdArgs args)
        {
            var result = Outcome.Success;
            var dir = AsmWs.OutDir(arg(args,0).Value);
            var filter = args.Length > 1 ?arg(args,1).Value : "*.*";
            Files(dir.Files(filter,true));
            return result;
        }

        // .asm-outfiles llvm-llc/dumps *.asm
            //=> ImportAsm();

    }
}