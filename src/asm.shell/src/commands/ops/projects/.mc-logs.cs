//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".mc-logs")]
        Outcome McLog(CmdArgs args)
        {
            var result = Outcome.Success;
            CollectAsmSyntax();
            return result;
        }
   }
}