//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".def")]
        Outcome Def(CmdArgs args)
        {
            var result = Outcome.Success;
            var lines = Db.DefLines(arg(args,0).Value);
            iter(lines, line => Write(line));
            return result;
        }
    }
}