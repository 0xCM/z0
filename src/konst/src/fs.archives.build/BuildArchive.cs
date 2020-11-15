//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBuildArchive : IFileArchive
    {
        IEnumerable<FS.FilePath> BuildFiles(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true);

        IEnumerable<FS.FilePath> ExeFiles()
            => BuildFiles(Exe);

        IEnumerable<FS.FilePath> JsonDepsFiles()
            => BuildFiles(JsonDeps);

        IEnumerable<FS.FilePath> DllFiles()
            => BuildFiles(Dll);

        IEnumerable<FS.FilePath> PdbFiles()
            => BuildFiles(Pdb);

        IEnumerable<FS.FilePath> LibFiles()
            => BuildFiles(Lib);
    }
    public struct BuildArchive : IBuildArchive
    {
        readonly IWfShell Wf;

        public FS.FolderPath Root {get;}

        public BuildArchiveSettings Spec {get;}

        [MethodImpl(Inline)]
        public BuildArchive(IWfShell wf, BuildArchiveSettings spec)
        {
            Wf = wf;
            Root = spec.Root;
            Spec = spec;
        }

        public IModuleArchive Modules
            => ModuleArchive.create(Root);
    }
}