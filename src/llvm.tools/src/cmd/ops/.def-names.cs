//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".def-names")]
        Outcome DefNames(CmdArgs args)
        {
            var result = Outcome.Success;
            var names = Db.DefNames();
            iter(names, Write);
            return result;
        }
    }
}
