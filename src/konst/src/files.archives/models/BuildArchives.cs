//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct BuildArchives
    {
        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive create(IWfShell wf,  FS.FolderPath root)
            => new BuildArchive(wf, root);

        [MethodImpl(Inline), Op]
        public static IBuildArchive create(IWfShell wf)
            => create(wf, FS.path(wf.Controller.Component.Location).FolderPath);
    }
}