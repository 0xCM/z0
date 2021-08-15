//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".layouts")]
        Outcome Layouts(CmdArgs args)
        {
            var result = Outcome.Success;
            // mov r/m8,r8 # MOV r/m8,r8 | 88 /r | (ModRM:r/m (w), ModRM:reg (r))


            return result;
        }

    }
}