//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial class LlvmCmd
    {
        [CmdOp(".classes")]
        Outcome Classes(CmdArgs args)
        {
            var result = Outcome.Success;
            Db.Classes();
            return result;
        }

        [CmdOp(".defs")]
        Outcome Defs(CmdArgs args)
        {
            var result = Outcome.Success;
            Db.Defs();
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