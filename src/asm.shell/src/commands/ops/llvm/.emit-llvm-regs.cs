//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.llvm;

    partial class AsmCmdService
    {
        [CmdOp(".emit-llvm-regs")]
        Outcome LlvmRegs(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Symbols.index<MC.Register>();
            EmitSymKinds(src, TableWs().Root + FS.file("llvm.regs", FS.Csv));
            return result;
        }
    }
}