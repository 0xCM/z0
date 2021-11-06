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
        [CmdOp(".class-names")]
        Outcome ClassNames(CmdArgs args)
        {
            var result = Outcome.Success;
            var names = Db.ClassNames();
            iter(names, Write);
            return result;
        }
    }
}