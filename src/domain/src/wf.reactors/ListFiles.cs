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

        static CmdResult run(IWfShell wf, ListFilesCmd cmd)
        {
            var archive = FileArchives.create(cmd.SourceDir);
            var files = archive.Enumerate(cmd.Extensions, true).Where(f => !f.Name.EndsWith(".resources.dll"));
            var counter = 0;
            using var writer = cmd.TargetPath.Writer();

            foreach(var file in files)
            {
                var listed = new ListedFile(counter++, file);
                writer.WriteLine(listed.Format());
            }

            wf.EmittedFile(counter, cmd.TargetPath);

            return Cmd.ok(cmd);
        }
    }
}