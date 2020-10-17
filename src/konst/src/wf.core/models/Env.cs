//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Reifies an application environment service predicated on environment variables
    /// </summary>
    public struct Env
    {
        public FS.FolderPath LogRoot;

        public FS.FolderPath DevRoot;

        public FS.FolderPath ArchiveRoot;

        public static FS.FolderPath DbRoot => FS.dir("j:\\database");

        [MethodImpl(Inline)]
        public Env(EnvVar<FS.FolderPath> log, EnvVar<FS.FolderPath> dev, EnvVar<FS.FolderPath> archive)
        {
            LogRoot = log;
            DevRoot = dev;
            ArchiveRoot = archive;
        }
    }
}