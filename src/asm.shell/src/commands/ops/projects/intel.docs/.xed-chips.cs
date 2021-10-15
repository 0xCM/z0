//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-chips")]
        Outcome XedChips(CmdArgs args)
            => ShowSyms(Xed.ChipCodes());
    }
}