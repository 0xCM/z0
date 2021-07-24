//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".emit-xed-tables")]
        Outcome EmitXedTables(CmdArgs args)
        {
            var dst = State.Tables().Subdir(AsmTableScopes.IntelXed);
            dst.Clear();
            Wf.IntelXed().EmitTables(dst);
            return true;
        }
    }
}