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
            => RunBuildScript(args,McBuild);
    }
}