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

        [MethodImpl(Inline)]
        public WfPaths(FS.FolderPath log)
        {
            LogRoot = FolderPath.Define(log.Name);
            LogDir = log;
        }
    }
}