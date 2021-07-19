//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llc-obj")]
        public Outcome LlcObj(CmdArgs args)
        {
            var outcome = Outcome.Success;

            var vars = Cmd.vars(
                ("SrcFile", arg(args,0).Value),
                ("iset",arg(args,1).Value),
                ("SrcDir", SrcDir().Format(PathSeparator.BS))
                );

            var cmd = Cmd.cmdline(ToolBase().Script(Toolspace.llvm_llc, "emit-obj").Format(PathSeparator.BS));
            var response = ScriptRunner.RunCmd(cmd, vars);
            return outcome;
        }
    }
}