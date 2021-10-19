//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        [CmdOp(".build")]
        Outcome BuildProject(CmdArgs args)
            => RunProjectScript(State.Project(), Build);
    }
}