//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-forms-emit")]
        Outcome AsmFormsEmit(CmdArgs args)
            => EmitAsmForms();
    }
}