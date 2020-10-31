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