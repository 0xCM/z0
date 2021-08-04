//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-isaext")]
        Outcome XedIsaExt(CmdArgs args)
            => WriteSyms(Xed.IsaExtensions());
    }
}