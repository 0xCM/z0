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
        [MethodImpl(Inline), Op]
        public static IWfPaths create(FS.FolderPath root)
            => new WfPaths(root);

        [MethodImpl(Inline), Op]
        public static IWfPaths create()
            => new WfPaths(EnvVars.Common.LogRoot);

        public FolderPath LogRoot {get;}

        /// <summary>
        /// The global application log root
        /// </summary>
        public FS.FolderPath LogDir {get;}

        [MethodImpl(Inline)]
        public WfPaths(FS.FolderPath log)
        {
            LogRoot = FolderPath.Define(log.Name);
            LogDir = log;
        }
    }
}