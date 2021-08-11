//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".opcodes-load")]
        Outcome LoadOpcodes(CmdArgs args)
        {
            var result = LoadOpcodes();
            if(result.Fail)
                return result;

            Write(string.Format("Absorbed {0} opcodes", State.OpCodes().Length));

            return result;
        }
    }
}