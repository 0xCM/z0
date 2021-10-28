//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".mc-build")]
        Outcome BuildMc(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), arg(args,0).Value, McBuild, "asm");

        [CmdOp(".c-build")]
        Outcome BuildCProj(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), arg(args,0).Value, CBuild, "c");

        [CmdOp(".cpp-build")]
        Outcome BuildCpp(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), arg(args,0).Value, CppBuild, "cpp");

        [CmdOp(".llc-sse")]
        Outcome LlcSse(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildSse);

        [CmdOp(".llc-sse2")]
        Outcome LlcSse2(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildSse2);

        [CmdOp(".llc-sse3")]
        Outcome LlcSse3(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildSse3);

        [CmdOp(".llc-sse41")]
        Outcome LlcSse41(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildSse41);

        [CmdOp(".llc-sse42")]
        Outcome LlcSse42(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildSse42);

        [CmdOp(".llc-avx")]
        Outcome LlcAvx(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildAvx);

        [CmdOp(".llc-avx2")]
        Outcome LlcAvx2(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildAvx2);

        [CmdOp(".llc-avx512")]
        Outcome LlcAvx512(CmdArgs args)
            => ProjectScripts.RunScript(State.Project(), string.Empty, LlcBuildAvx512);
    }
}