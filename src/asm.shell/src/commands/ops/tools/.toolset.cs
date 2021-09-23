//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".toolset")]
        Outcome TS(CmdArgs args)
        {
            var result = Outcome.Success;
            var dst = FS.dir("J:/llvm/toolbase");
            var spec = FS.dir("J:/llvm/toolset");
            var svc = Wf.Tooling();
            svc.CreateLlvmToolbase(spec,dst);

            return result;
        }
    }
}