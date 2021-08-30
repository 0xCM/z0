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
        [CmdOp(".sym-collect")]
        Outcome CollectSyms(CmdArgs args)
        {
            var result = Outcome.Success;
            var outpath = OutData<ObjSymRecord>();
            var files = ProjectOut().Files(FS.Sym,true);
            Write(string.Format("Collecting symbols from {0} files", files.Length));
            var symbols = LlvmNm.Collect(files, outpath);
            return result;
        }
    }
}