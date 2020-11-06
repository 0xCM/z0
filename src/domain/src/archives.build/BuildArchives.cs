//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct BuildArchives
    {
        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive create(IWfShell wf,  FS.FolderPath root)
            => new BuildArchive(wf, new BuildArchiveSettings(EmptyString, root));

        [MethodImpl(Inline), Op]
        public static IBuildArchive create(IWfShell wf,  BuildArchiveSettings spec)
            => new BuildArchive(wf, spec);

        [MethodImpl(Inline), Op]
        public static IBuildArchive create(IWfShell wf)
            => create(wf, FS.path(wf.Controller.Component.Location).FolderPath);

        [Op]
        public void list(IWfShell wf, BuildArchiveSettings spec)
        {
            var archive = BuildArchives.create(wf, spec);
            var types = array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib);
            var cmd = EmitFileList.specify(wf, spec.Label + ".artifacts", archive.Root, types);
            EmitFileList.run(wf, cmd);
        }
    }
}