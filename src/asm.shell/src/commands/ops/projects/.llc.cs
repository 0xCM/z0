//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static WsAtoms;
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".llc")]
        Outcome Llc(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuild, false, out _);

        [CmdOp(".llc-sse2")]
        Outcome LlcSse2(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildSse2, false, out _);

        [CmdOp(".llc-sse3")]
        Outcome LlcSse3(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildSse3, false, out _);

        [CmdOp(".llc-sse41")]
        Outcome LlcSse41(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildSse41, false, out _);

        [CmdOp(".llc-sse42")]
        Outcome LlcSse42(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildSse42, false, out _);

        [CmdOp(".llc-avx")]
        Outcome LlcAvx(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildAvx, false, out _);

        [CmdOp(".llc-avx2")]
        Outcome LlcAvx2(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildAvx2, false, out _);

        [CmdOp(".llc-avx512")]
        Outcome LlcAvx512(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildAvx512, false, out _);
    }
}