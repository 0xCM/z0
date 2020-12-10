//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;

    sealed class EmitFileList : CmdReactor<EmitFileListCmd,CmdResult>
    {
        protected override CmdResult Run(EmitFileListCmd cmd)
            => run(Wf,cmd);

        static CmdResult run(IWfShell wf, EmitFileListCmd cmd)
        {
            var archive = FileArchives.create(cmd.SourceDir);
            var files = archive.Files(true, cmd.FileKinds).Where(f => !f.Name.EndsWith(".resources.dll"));
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