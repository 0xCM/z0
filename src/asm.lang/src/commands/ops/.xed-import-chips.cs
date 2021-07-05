//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-import-chips")]
        Outcome ImportChips(CmdArgs args)
            => Wf.IntelXed().EmitChipMap();
    }
}