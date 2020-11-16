//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public sealed class EmitFileList : CmdHost<EmitFileList, EmitFileListCmd>
    {
        [Op]
        public static EmitFileListCmd specify(IWfShell wf, string name, FS.FolderPath src, params FS.FileExt[] kinds)
        {
            var cmd = Spec();
            cmd.ListName = name;
            cmd.SourceDir = src;
            cmd.FileKinds = kinds;
            cmd.TargetPath = wf.Db().Doc(name, ArchiveFileKinds.Csv);
            return cmd;
        }

        [CmdWorker]
        public static CmdResult run(IWfShell wf, EmitFileListCmd spec)
        {
            var archive = FileArchives.create(spec.SourceDir);
            var files = archive.Files(true, spec.FileKinds).Where(f => !f.Name.EndsWith(".resources.dll"));
            var counter = 0;
            using var writer = spec.TargetPath.Writer();

            foreach(var file in files)
            {
                var listed = new ListedFile(counter++, file);
                writer.WriteLine(listed.Format());
            }

            wf.EmittedFile(counter, spec.TargetPath);

            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitFileListCmd spec)
            => run(wf,spec);
    }
}