//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    partial class AsmCmdService
    {
        [CmdOp(".llvm-records")]
        Outcome LlRecords(CmdArgs args)
        {
            var names = LlvmRecords.Defs(llvm.LlvmDatasetKind.Instructions);
            iter(names, n => Write(n));
            return true;
        }
    }
}