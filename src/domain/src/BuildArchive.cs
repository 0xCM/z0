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

    public interface IBuildArchive : IFileArchive<BuildArchive>
    {
        IModuleArchive Modules {get;}
    }

    public struct BuildArchive : IBuildArchive
    {
        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive create(FS.FolderPath root)
            => new BuildArchive(root);

        public FS.FolderPath Root{get;}


        [MethodImpl(Inline)]
        public BuildArchive(FS.FolderPath root)
            => Root = root;

        public IModuleArchive Modules
            => ModuleArchive.create(Root);
    }
}