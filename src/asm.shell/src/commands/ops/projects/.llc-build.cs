//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".llc-sse")]
        Outcome LlcSse(CmdArgs args)
            => RunProjectScript(args, LlcBuildSse);

        [CmdOp(".llc-sse2")]
        Outcome LlcSse2(CmdArgs args)
            => RunProjectScript(args, LlcBuildSse2);

        [CmdOp(".llc-sse3")]
        Outcome LlcSse3(CmdArgs args)
            => RunProjectScript(args, LlcBuildSse3);

        [CmdOp(".llc-sse41")]
        Outcome LlcSse41(CmdArgs args)
            => RunProjectScript(args, LlcBuildSse41);

        [CmdOp(".llc-sse42")]
        Outcome LlcSse42(CmdArgs args)
            => RunProjectScript(args, LlcBuildSse42);

        [CmdOp(".llc-avx")]
        Outcome LlcAvx(CmdArgs args)
            => RunProjectScript(args, LlcBuildAvx);

        [CmdOp(".llc-avx2")]
        Outcome LlcAvx2(CmdArgs args)
            => RunProjectScript(args, LlcBuildAvx2);

        [CmdOp(".llc-avx512")]
        Outcome LlcAvx512(CmdArgs args)
            => RunProjectScript(args, LlcBuildAvx512);
    }
}