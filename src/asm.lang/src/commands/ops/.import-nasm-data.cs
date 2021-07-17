//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-nasm-data")]
        Outcome EmitNasmInstructions(CmdArgs args)
        {
            Wf.NasmCatalog().ImportInstructions();
            return true;
        }
    }
}