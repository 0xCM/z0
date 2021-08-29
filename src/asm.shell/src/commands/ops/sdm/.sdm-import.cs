//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".sdm-import")]
        Outcome SdmImport(CmdArgs args)
        {
            var opcodes = Sdm.ImportSdmOpCodes();
            State.SdmOpCodes(opcodes);
            var forms = Sdm.EmitForms(opcodes);
            return Sdm.EmitOpCodeStrings(opcodes);
        }
    }
}