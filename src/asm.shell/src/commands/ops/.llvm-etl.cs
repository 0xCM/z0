//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.llvm;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-etl")]
        Outcome RunLlvmEtl(CmdArgs args)
            => LlvmEtl.RunEtl();

        [CmdOp(".llvm-list-gen")]
        Outcome LlvmListGen(CmdArgs args)
            => LlvmEtl.GenLists();
    }
}