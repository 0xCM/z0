//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-xed-cat")]
        Outcome EmitXedCatalog(CmdArgs args)
        {
            Wf.IntelXed().EmitCatalog();
            return true;
        }
    }
}