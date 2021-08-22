//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.llvm;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-records")]
        Outcome LlvmRecords(CmdArgs args)
        {
            var sources = LlvmRecordSources();
            return true;
        }
    }
}