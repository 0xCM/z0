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

    public struct DbArchive : IDbArchive<DbArchive>, IDbPaths
    {
        public ArchiveConfig Settings {get;}

        [MethodImpl(Inline)]
        public DbArchive(ArchiveConfig config)
        {
            Settings = config;
        }

        public FS.FolderPath Root
            => Settings.Root;

        FS.FolderPath IDbPaths.DbRoot
            => Settings.Root;
    }
}