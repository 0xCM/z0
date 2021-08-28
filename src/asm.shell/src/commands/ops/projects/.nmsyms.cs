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
        [CmdOp(".nmsyms")]
        Outcome ObjSyms(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = State.Files(FS.Sym).View;
            var count = src.Length;
            var formatter = Tables.formatter<ObjSymRecord>(ObjSymRecord.RenderWidths);
            var buffer = list<ObjSymRecord>();
            var outpath = ProjectOut() + Tables.filename<ObjSymRecord>();
            LlvmNm.Collect(src, outpath);
            return result;
        }

        FS.FolderPath ProjectOut()
            => Ws.Projects().OutDir(State.Project());
    }
}