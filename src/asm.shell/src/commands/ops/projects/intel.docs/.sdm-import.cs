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
        IProjectWs IntelDocs()
            => Ws.Project("intel.docs");

        [CmdOp(".sdm-import")]
        Outcome SdmImport(CmdArgs args)
        {
            var project = IntelDocs();
            var result = Outcome.Success;
            var details = Sdm.ImportOpCodeDetails();
            var forms = Sdm.EmitForms(details);
            Sdm.EmitOpCodeStrings(details);

            var opcodes = SdmModels.opcodes(details).View;
            var count = opcodes.Length;
            var dst = project.Subdir(imports) + FS.file("sdm.opcodes", FS.Txt);
            using var writer = dst.AsciWriter();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(opcodes,i).Format());

            return result;
        }
    }
}