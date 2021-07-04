//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-intrinsics")]
        public Outcome ImportIntrinsics(CmdArgs args)
        {
            Wf.IntelIntrinsicsPipe().Import();
            return true;
        }

        [CmdOp(".import-chip-map")]
        Outcome ImportChips(CmdArgs args)
            => Wf.IntelXed().EmitChipMap();

        [CmdOp(".import-xed")]
        Outcome ImportXed(CmdArgs args)
        {
            Wf.IntelXed().EmitCatalog();
            return true;
        }
    }
}