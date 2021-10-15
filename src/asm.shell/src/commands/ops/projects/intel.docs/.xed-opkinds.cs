//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-opkinds")]
        Outcome XedOpKinds(CmdArgs args)
            => ShowSyms(Xed.OperandKinds());
    }
}