//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class DumpCliTables : CmdReactor<DumpCliTablesCmd>
    {
        protected override CmdResult Run(DumpCliTablesCmd cmd)
            => cmd.ToResult(CliTables.init(Wf).DumpTables(cmd.Source, cmd.Target));
    }


}