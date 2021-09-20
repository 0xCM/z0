//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".sdm-import")]
        Outcome SdmImport(CmdArgs args)
        {
            var result = Outcome.Success;
            var dir = Ws.Tables().Subdir(machine);
            var details = Sdm.ImportSdmOpCodes(Ws.Tables().Subdir(machine));
            var forms = Sdm.EmitForms(details, dir);
            Sdm.EmitOpCodeStrings(details);

            var opcodes = SdmModels.opcodes(details).View;
            var count = opcodes.Length;
            var dst = dir + FS.file("sdm.opcodes", FS.Txt);
            using var writer = dst.AsciWriter();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(opcodes,i).Format());

            return result;
        }
    }
}