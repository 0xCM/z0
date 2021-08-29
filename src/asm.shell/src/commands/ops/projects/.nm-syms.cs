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
        [CmdOp(".nm-syms")]
        Outcome ObjSyms(CmdArgs args)
        {
            var result = Outcome.Success;
            var outpath = ProjectOut() + Tables.filename<ObjSymRecord>();
            var symbols = LlvmNm.Collect(State.Files(FS.Sym).View, outpath);
            return result;
        }
    }
}