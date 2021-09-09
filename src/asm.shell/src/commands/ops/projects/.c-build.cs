//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".c-build")]
        Outcome BuildCProj(CmdArgs args)
            => RunProjectScript(args, CBuild, c);
    }
}