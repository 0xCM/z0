//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class DumpCliTables : CmdReactor<DumpCliTablesCmd>
    {
        protected override CmdResult Run(DumpCliTablesCmd cmd)
        {
            CliTables.create(Wf).DumpMetadata(cmd.Source, cmd.Target);
            return Cmd.ok(cmd);
        }
    }
}