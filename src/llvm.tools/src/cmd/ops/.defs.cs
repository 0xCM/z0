//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial class LlvmCmd
    {
        [CmdOp(".defs")]
        Outcome Defs(CmdArgs args)
        {
            var result = Outcome.Success;
            var dst = LlvmPaths.TmpFile("defs", FS.Txt);
            using var writer = dst.AsciWriter();
            Db.Defs(writer);
            return result;
        }

        [CmdOp(".def")]
        Outcome Def(CmdArgs args)
        {
            var result = Outcome.Success;
            Db.Def(arg(args,0).Value);
            return result;
        }
    }
}