//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitRuntimeIndex : CmdReactor<EmitRuntimeIndexCmd,CmdResult>
    {
        protected override CmdResult Run(EmitRuntimeIndexCmd cmd)
            => Reactions.react(Wf, cmd);
    }
}
