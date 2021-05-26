//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;

    sealed class ListFiles : CmdReactor<ListFilesCmd,CmdResult>
    {
        protected override CmdResult Run(ListFilesCmd cmd)
            => run(Wf,cmd);

        static CmdResult run(IWfRuntime wf, ListFilesCmd cmd)
        {
            var archive = FileArchives.create(cmd.SourceDir);
            var files = cmd.SourceDir.EnumerateFiles(true).Where(f => cmd.Extensions.Contains(f.Ext));
            var counter = 0;
            var flow = wf.EmittingFile(cmd.TargetPath);
            using var writer = cmd.TargetPath.Writer();

            foreach(var file in files)
            {
                var listed = new ListedFile(counter++, file);
                writer.WriteLine(listed.Format());
            }

            wf.EmittedFile(flow, counter);

            return Cmd.ok(cmd);
        }
    }
}