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
        {
            var result = Outcome.Success;
            var src = Xed.OperandKinds();
            WriteSyms(src);
            return result;
        }
    }
}