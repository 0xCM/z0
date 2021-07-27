//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-xed-data")]
        Outcome EmitXedTables(CmdArgs args)
        {
            var dst = TableWs().Subdir(AsmTableScopes.IntelXed);
            dst.Clear();
            Wf.IntelXed().EmitTables(dst);
            return true;
        }

        // .xed-isa CASCADE_LAKE
    }
}