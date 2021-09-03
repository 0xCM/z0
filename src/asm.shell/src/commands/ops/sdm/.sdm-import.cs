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
        Index<SdmOpCodeDetail> OpCodeDetails()
            => Sdm.ImportSdmOpCodes(Ws.Tables().Subdir(machine));

        [CmdOp(".sdm-opcodes")]
        Outcome SdmOpCodes(CmdArgs args)
        {
            var result = Outcome.Success;
            var dir = Ws.Tables().Subdir(machine);
            var details = State.Records(OpCodeDetails);
            var forms = Sdm.EmitForms(details, dir);
            Sdm.EmitOpCodeStrings(details);
            var opcodes = SdmModels.opcodes(details).View;
            var count = opcodes.Length;
            var dst = dir + FS.file("sdm.opcodes", FS.Txt);
            using var writer = dst.AsciWriter();
            for(var i=0; i<count; i++)
            {
                ref readonly var opcode = ref skip(opcodes,i);
                writer.WriteLine(opcode.Format());
            }

            return result;
        }
    }
}