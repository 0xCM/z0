//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".list")]
        Outcome ShowList(CmdArgs args)
        {
            var result = Outcome.Success;
            var list = Db.List(arg(args,0));
            iter(list, item => Write(item.Format()));
            return result;
        }
    }
}