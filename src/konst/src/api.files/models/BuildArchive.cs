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

    public readonly struct BuildArchive : IBuildArchive
    {
        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive create(ArchiveConfig root)
            => new BuildArchive(root);

        public FS.FolderPath Root => Config.Root;

        public ArchiveConfig Config {get;}

        [MethodImpl(Inline)]
        public BuildArchive(ArchiveConfig config)
            => Config = config;

        public IModuleArchive Modules
            => ModuleArchive.create(Config);
    }
}