//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-xed-forms")]
        public Outcome ImportXedForms(CmdArgs args)
        {
            var result = Outcome.Success;
            var svc = Wf.IntelXed();
            var src = Workspace.DataSource(xed) + FS.file("xed-idata", FS.Txt);
            var dst = Workspace.ImportTable<XedFormInfo>();
            svc.ImportFormSummaries(src,dst);
            return result;
        }
    }
}