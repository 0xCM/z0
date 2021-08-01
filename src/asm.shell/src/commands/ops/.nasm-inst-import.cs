//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".nasm-inst-import")]
        Outcome ImportNasm(CmdArgs args)
        {
            var records = NasmCatalog.ImportInstructions();
            return true;
        }
    }
}