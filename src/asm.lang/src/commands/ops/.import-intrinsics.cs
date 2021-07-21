//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".emit-intrinsics")]
        public Outcome ImportIntrinsics(CmdArgs args)
        {
            Wf.IntelIntrinsicsPipe().Emit();
            return true;
        }
    }
}