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
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuild);

        [CmdOp(".llc-sse2")]
        Outcome LlcSse2(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuildSse2);

        [CmdOp(".llc-sse3")]
        Outcome LlcSse3(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuildSse3);

        [CmdOp(".llc-sse41")]
        Outcome LlcSse41(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuildSse41);

        [CmdOp(".llc-sse42")]
        Outcome LlcSse42(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuildSse42);

        [CmdOp(".llc-avx")]
        Outcome LlcAvx(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuildAvx);

        [CmdOp(".llc-avx2")]
        Outcome LlcAvx2(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuildAvx2);

        [CmdOp(".llc-avx512")]
        Outcome LlcAvx512(CmdArgs args)
            => OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, win, LlcBuildAvx512);
    }
}