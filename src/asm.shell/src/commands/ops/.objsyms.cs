//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using llvm;

    partial class AsmCmdService
    {
        [CmdOp(".objsyms")]
        Outcome ObjSyms(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = State.Files(FS.Sym).View;
            var count = src.Length;
            var formatter = Tables.formatter<ObjSymRecord>(ObjSymRecord.RenderWidths);
            var buffer = list<ObjSymRecord>();
            var ws = State.Workspace();
            var outpath = ws.OutDir() + Tables.filename<ObjSymRecord>();
            Wf.LlvmNm().Collect(src, outpath);
            return result;
        }
    }
}