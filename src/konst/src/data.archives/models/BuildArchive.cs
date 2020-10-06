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

    using api = Archives;

    public readonly struct BuildArchive : IBuildArchive
    {
        public FS.FolderPath Root => Config.Root;

        public ArchiveConfig Config {get;}

        [MethodImpl(Inline)]
        public BuildArchive(ArchiveConfig config)
            => Config = config;

        public IModuleArchive Modules => api.modules(Config);
    }
}