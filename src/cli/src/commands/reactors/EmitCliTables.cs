//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection.Metadata;

    sealed class EmitCliTables : CmdReactor<EmitCliTablesCmd, CmdResult>
    {
        protected override CmdResult Run(EmitCliTablesCmd cmd)
            => react(Wf, cmd);

        public static CmdResult react(IWfShell wf, in EmitCliTablesCmd cmd)
        {
            (var success, var msg) = MetadataTableEmitter.emit(cmd.Source.Name, cmd.Target.Name);
            if(success)
                return Cmd.ok(cmd);
            else
                return Cmd.fail(cmd,msg);
        }
    }
}