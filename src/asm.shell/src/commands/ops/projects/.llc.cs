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
            => RunBuildScript(args, LlcBuild);

        [CmdOp(".llc-sse2")]
        Outcome LlcSse2(CmdArgs args)
            => RunBuildScript(args, LlcBuildSse2);

        [CmdOp(".llc-sse3")]
        Outcome LlcSse3(CmdArgs args)
            => RunBuildScript(args, LlcBuildSse3);

        [CmdOp(".llc-sse41")]
        Outcome LlcSse41(CmdArgs args)
            => RunBuildScript(args, LlcBuildSse41);

        [CmdOp(".llc-sse42")]
        Outcome LlcSse42(CmdArgs args)
            => RunBuildScript(args, LlcBuildSse42);

        [CmdOp(".llc-avx")]
        Outcome LlcAvx(CmdArgs args)
            => RunBuildScript(args, LlcBuildAvx);

        [CmdOp(".llc-avx2")]
        Outcome LlcAvx2(CmdArgs args)
            => RunBuildScript(args, LlcBuildAvx2);

        [CmdOp(".llc-avx512")]
        Outcome LlcAvx512(CmdArgs args)
            => RunBuildScript(args, LlcBuildAvx512);
            //=> OmniScript.RunProjectScript(State.Project(), arg(args,0).Value, LlcBuildAvx512, false, out _);
    }
}