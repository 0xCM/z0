//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.IO;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata;

    sealed class DumpCliTables : CmdReactor<DumpCliTablesCmd,CmdResult>
    {
        protected override CmdResult Run(DumpCliTablesCmd cmd)
            => react(Wf, cmd);

        public static CmdResult react(IWfShell wf, in DumpCliTablesCmd cmd)
        {
            wf.EmittingFile(cmd.Source, cmd.Target);
            using var stream = File.OpenRead(cmd.Source.Name);
            using var peFile = new PEReader(stream);
            using var target = cmd.Target.Writer();
            var reader = peFile.GetMetadataReader();
            var viz = new MetadataTraverser(reader, target);
            viz.Visualize();
            return Cmd.ok(cmd);
        }
    }
}