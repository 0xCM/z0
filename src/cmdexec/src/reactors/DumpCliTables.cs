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

    partial class XReact
    {
        public static  CmdResult<C,P> ToResult<C,P>(this C spec, Outcome<P> outcome)
            where C : struct, ICmdSpec<C>
                => Cmd.result(spec, outcome.Ok, outcome.Data, outcome.Message);
    }
}