//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".llc-sse2")]
        Outcome LlcSse2(CmdArgs args)
            => RunBuildScript(args, LlcBuildSse2);
    }
}