//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-xed-forms")]
        public Outcome ImportXedForms(CmdArgs args)
        {
            var result = Outcome.Success;
            var svc = Wf.IntelXed();
            var src = Workspace.DataSource(xed) + FS.file("xed-idata", FS.Txt);
            var dst = Workspace.ImportDir(xed) + FS.file("xed.idata", FS.Csv);
            svc.ImportFormSummaries(src,dst);
            return result;
        }
    }
}