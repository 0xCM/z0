//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".llvm-mc-asm")]
        Outcome LLvmMcAssemble(CmdArgs args)
        {
            var result = Outcome.Success;
            var id = arg(args,0).Value;
            return McAssemble(AsmWs.AsmPath(id),AsmWs.ObjOut());
        }
    }
}