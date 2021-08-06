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
            var src = AsmWs.AsmPath(id);
            var dst = AsmWs.ObjOut();
            return LlvmMcAssemble(src,dst);
        }
    }
}