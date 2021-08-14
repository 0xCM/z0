//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".llvm-mc-disasm")]
        Outcome Disasm(CmdArgs args)
        {
            return DisasmHex();
        }
    }
}