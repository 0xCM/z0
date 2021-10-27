//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using types;

    using static Root;
    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".test")]
        Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;

            var input = "a -> b -> c -> d";
            var output = dag.parse(input);
            Write(output.Format());
            return result;
        }

    }
}