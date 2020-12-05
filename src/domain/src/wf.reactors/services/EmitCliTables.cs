//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class EmitCliTables : CmdReactor<EmitCliTablesCmd, CmdResult>
    {
        protected override CmdResult Run(EmitCliTablesCmd cmd)
            => Reactions.react(Wf, cmd);
    }
}