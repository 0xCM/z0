//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct BuildArchive : IBuildArchive
    {
        readonly IWfShell Wf;

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public BuildArchive(IWfShell wf, FS.FolderPath root)
        {
            Wf = wf;
            Root = root;
        }

        public IModuleArchive Modules
            => FileArchives.modules(Root);
    }
}