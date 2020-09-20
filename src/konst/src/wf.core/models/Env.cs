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
    public readonly struct Env
    {
        public readonly FolderPath LogRoot;

        public readonly FolderPath DevRoot;

        public readonly FolderPath PubRoot;

        [MethodImpl(Inline)]
        public Env(EnvVar<FolderPath> log, EnvVar<FolderPath> dev, EnvVar<FolderPath> archive)
        {
            LogRoot = log;
            DevRoot = dev;
            PubRoot = archive;
        }
    }
}