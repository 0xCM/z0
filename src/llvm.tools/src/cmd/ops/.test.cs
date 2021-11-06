//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using types;

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

        [CmdOp(".test-logs")]
        Outcome ReadJson(CmdArgs args)
        {
            var result = Outcome.Success;
            var entries = LlvmTests.TestLog(FS.path(@"J:\llvm\toolset\logs\llvm-tests-detail.json"));
            Write(string.Format("Parsed {0} entries", entries.Length));
            return result;
        }
    }
}