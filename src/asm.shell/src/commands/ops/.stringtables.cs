//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".stringtables")]
        Outcome EmitStringtables(CmdArgs args)
            => EmitStringtables();
   }
}