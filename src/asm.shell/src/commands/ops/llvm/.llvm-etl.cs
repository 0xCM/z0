//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".llvm-etl")]
        Outcome RunLlvmEtl(CmdArgs args)
        {
            var result = LlvmEtl.RunEtl(out var datasets);
            return result;
        }

        [CmdOp(".llvm-list-import")]
        Outcome LlvmListGen(CmdArgs args)
            => LlvmEtl.ImportLists();
    }
}