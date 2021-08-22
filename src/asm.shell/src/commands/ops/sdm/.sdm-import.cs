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
            => SdmImport();

        Outcome SdmImport()
        {
            var opcodes = SdmOpCodes();
            var dst = TableWs().Root + FS.file("asm.forms", FS.Txt);
            var forms = AsmEtl.EmitAsmForms(opcodes, dst);
            return AsmEtl.EmitOpCodeStrings(opcodes);
        }

        ReadOnlySpan<Table> SdmTables()
        {
            return AsmEtl.ReadSdmTables();
        }

        ReadOnlySpan<SdmOpCodeDetail> SdmOpCodes()
        {
            if(State.SdmOpCodeDetail().IsEmpty)
                State.SdmOpCodeDetail(AsmEtl.ImportSdmOpCodes());
            return State.SdmOpCodeDetail();
        }
    }
}