//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".llc-avx512")]
        Outcome LlcAvx512(CmdArgs args)
            => RunBuildScript(args, LlcBuildAvx512);
    }
}