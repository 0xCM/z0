//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".intel-intrinsics")]
        public Outcome ImportIntelIntrinsics(CmdArgs args)
        {
            Wf.IntelIntrinsics().Emit(Ws.Tables().Subdir(machine));
            return true;
        }
    }
}