//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     using System;

     using static core;

    partial class AsmCmdService
    {
        [CmdOp(".sdm-import")]
        Outcome SdmImport(CmdArgs args)
        {
            var opcodes = AsmEtl.ImportSdmOpCodes();
            State.SdmOpCodeDetail(opcodes);
            var dst = TableWs().Root + FS.file("asm.forms", FS.Txt);
            var forms = AsmEtl.EmitAsmForms(opcodes, dst);
            return AsmEtl.EmitOpCodeStrings(opcodes);
        }
    }
}