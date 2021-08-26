//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".api-literals")]
        Outcome EmitApiLiterals(CmdArgs args)
            => EmitApiLiterals();
    }
}