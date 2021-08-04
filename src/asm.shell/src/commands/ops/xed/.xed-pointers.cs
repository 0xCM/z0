//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-pointers")]
        Outcome XedPointers(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Xed.PointerWidths();
            WriteSyms(src);
            return result;
        }
    }
}