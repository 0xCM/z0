//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".sdm-load")]
        Outcome LoadOpcodes(CmdArgs args)
        {
            var result = LoadSdmOpCodeDetails(out var opcodes);
            if(result.Fail)
                return result;

            Write(string.Format("Absorbed {0} opcodes", opcodes.Length));

            return result;
        }
    }
}