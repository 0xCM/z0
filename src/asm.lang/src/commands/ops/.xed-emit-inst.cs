//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-emit-inst")]
        public Outcome RunOldXedWf(CmdArgs args)
        {
            // var importer = XedRules.create(Wf);
            // var dst = Workspace.ImportDir(xed) + FS.file("instructions", FS.Txt);
            // importer.EmitInstructions(dst);
            return true;
        }
    }
}