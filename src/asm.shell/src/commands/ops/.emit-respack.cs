//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".emit-respack")]
        Outcome EmitRespPack(CmdArgs args)
        {
            Wf.ResPackEmitter().Emit();
            return true;
        }
    }
}