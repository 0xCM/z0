//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-tools")]
        Outcome Assemblers(CmdArgs args)
        {
            var result = Outcome.Success;
            Write(AsmToolSvc.Tools());
            return result;
        }
    }
}