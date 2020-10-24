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
    /// Reifies default application path service
    /// </summary>
    public readonly struct WfPaths : IWfPaths
    {
        public FolderPath LogRoot {get;}

        public FS.FolderPath LogDir {get;}

        public FS.FolderPath DbRoot {get;}

        public WfPaths(WfLogConfig logs)
        {
            LogDir = logs.Root;
            LogRoot = FolderPath.Define(LogDir.Name);
            DbRoot = logs.DbRoot;
        }
    }
}