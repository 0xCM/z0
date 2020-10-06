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

    public struct DatabaseArchive : IDatbaseArchive<DatabaseArchive>, IDatabasePaths
    {
        public ArchiveConfig Settings {get;}

        [MethodImpl(Inline)]
        public DatabaseArchive(ArchiveConfig config)
        {
            Settings = config;
        }

        public FS.FolderPath Root
            => Settings.Root;

        FS.FolderPath IDatabasePaths.DbRoot
            => Settings.Root;
    }
}