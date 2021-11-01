//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using records;

    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".relations")]
        Outcome Relations(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = LlvmPaths.Table<DefRelations>();
            var records = Db.LoadDefRelations();
            return result;
        }
    }
}