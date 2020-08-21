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
    public readonly struct AppPaths : IAppPaths
    {
        public PartId AppId {get;}

        public FolderPath LogRoot {get;}

        public FolderPath RuntimeRoot {get;}

        [MethodImpl(Inline)]
        public AppPaths(PartId id, FolderPath log)
        {
            AppId = id;
            LogRoot = log;
            RuntimeRoot = FolderPath.Define(Part.RuntimeRoot);
        }

        public static IAppPaths Default
            => new AppPaths(Part.ExecutingPart, EnvVars.Common.LogRoot);
    }
}