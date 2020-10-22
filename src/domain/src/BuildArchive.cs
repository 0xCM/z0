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

    public struct BuildArchiveSpec
    {
        public string Label;

        public FS.FolderPath Root;

        [MethodImpl(Inline)]
        public BuildArchiveSpec(string label, FS.FolderPath root)
        {
            Label = label;
            Root = root;
        }
    }

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
        public static IBuildArchive create(IWfShell wf,  FS.FolderPath root)
            => new BuildArchive(wf, new BuildArchiveSpec(EmptyString, root));

        [MethodImpl(Inline), Op]
        public static IBuildArchive create(IWfShell wf,  BuildArchiveSpec spec)
            => new BuildArchive(wf, spec);

        readonly IWfShell Wf;

        public FS.FolderPath Root {get;}

        public BuildArchiveSpec Spec {get;}

        [MethodImpl(Inline)]
        public BuildArchive(IWfShell wf, BuildArchiveSpec spec)
        {
            Wf = wf;
            Root = spec.Root;
            Spec = spec;
        }

        public IModuleArchive Modules
            => ModuleArchive.create(Root);
    }
}