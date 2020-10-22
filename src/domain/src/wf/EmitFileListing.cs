//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;

    using static Konst;
    using static z;

    [StructLayout(LayoutKind.Sequential), Cmd]
    public struct EmitFileListingCmd : ICmdSpec<EmitFileListingCmd>
    {
        public string ListName;

        public FS.FolderPath Source;

        public FS.FileExt[] Kinds;

        public FS.FilePath Target;
    }

    [CmdHost, ApiHost]
    public sealed class EmitFileListing : CmdHost<EmitFileListing, EmitFileListingCmd>
    {
        [Op]
        public static EmitFileListingCmd specify(IWfShell wf, string name, FS.FolderPath src, params FS.FileExt[] kinds)
        {
            var cmd = Spec();
            cmd.ListName = name;
            cmd.Source = src;
            cmd.Kinds = kinds;
            cmd.Target = wf.Db().Doc(name, ArchiveFileKinds.Csv);
            return cmd;
        }

        public static CmdResult run(IWfShell wf, in EmitFileListingCmd spec)
        {
            var archive = FS.archive(spec.Source);
            var files = archive.Files(true, spec.Kinds).Where(f => !f.Name.EndsWith(".resources.dll"));
            var counter = 0;
            using var writer = spec.Target.Writer();

            foreach(var file in files)
            {
                var listed = new ListedFile(counter++, file);
                writer.WriteLine(listed.Format());
            }

            wf.EmittedFile(counter, spec.Target);

            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitFileListingCmd spec)
            => run(wf,spec);
    }
}