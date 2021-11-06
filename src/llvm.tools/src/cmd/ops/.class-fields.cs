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
        [CmdOp(".class-fields")]
        Outcome ClassFields(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Db.ClassFields();
            iter(src, Write);
            return result;
        }
    }
}