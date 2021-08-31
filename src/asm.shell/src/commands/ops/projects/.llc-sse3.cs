//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".llc-sse3")]
        Outcome LlcSse3(CmdArgs args)
            => RunBuildScript(args, LlcBuildSse3);
    }
}