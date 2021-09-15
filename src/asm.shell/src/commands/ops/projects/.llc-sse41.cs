//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".llc-sse41")]
        Outcome LlcSse41(CmdArgs args)
            => RunProjectScript(args, LlcBuildSse41);
    }
}