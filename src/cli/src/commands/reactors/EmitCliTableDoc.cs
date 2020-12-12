//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection.Metadata;

    sealed class EmitCliTableDoc : CmdReactor<EmitCliTableDocCmd,CmdResult>
    {
        protected override CmdResult Run(EmitCliTableDocCmd cmd)
            => react(Wf, cmd);

        public static CmdResult react(IWfShell wf, in EmitCliTableDocCmd cmd)
        {
            var spec = cmd as ICmdSpec;
            wf.Status($"Executing {spec.CmdId}");

            var src = cmd.Source;
            var dst = cmd.Target.CreateParentIfMissing();

            if(!dst.Exists)
                return Cmd.fail(cmd, $"The source file {cmd.Source} does not exist");

            wf.EmittingFile(src, dst);

            (var success, var msg) = MetadataTableEmitter.emit(cmd.Source.Name, cmd.Target.Name);
            if(success)
                return Cmd.ok(cmd);
            else
                return Cmd.fail(cmd, msg);
        }
    }
}