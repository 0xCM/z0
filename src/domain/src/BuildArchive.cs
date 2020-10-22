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

    public interface IBuildArchive : IFileArchive<BuildArchive>
    {

    }

    public struct BuildArchive : IBuildArchive
    {
        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive create(IWfShell wf, FS.FolderPath root)
            => new BuildArchive(wf, root);

        readonly IWfShell Wf;

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public BuildArchive(IWfShell wf, FS.FolderPath root)
        {
            Wf = wf;
            Root = root;
        }

        public IModuleArchive Modules
            => ModuleArchive.create(Root);
    }
}