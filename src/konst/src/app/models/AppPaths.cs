//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Reifies default application path service
    /// </summary>
    public readonly struct AppPaths : IAppPaths
    {
        public PartId AppId {get;}

        public FolderPath LogRoot {get;}

        public FolderPath TrackedDataRoot {get;}

        [MethodImpl(Inline)]
        public static IAppPaths init(PartId id, FolderPath log = null, FolderPath data = null)
            => new AppPaths(id, log ?? Env.Current.LogDir, data ?? Env.Current.DevDir);

        [MethodImpl(Inline)]
        AppPaths(PartId id, FolderPath log, FolderPath data)
        {
            AppId = id;
            LogRoot = log;
            TrackedDataRoot = data;
        }

        public static IAppPaths Default 
            => new AppPaths(Part.ExecutingPart, Env.Current.LogDir, Env.Current.DevDir);
    }
}