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
    public readonly struct ShellPaths : IShellPaths
    {
        public PartId AppId {get;}

        public FolderPath LogRoot {get;}

        public FolderPath RuntimeRoot {get;}

        [MethodImpl(Inline)]
        public ShellPaths(PartId id, FolderPath log)
        {
            AppId = id;
            LogRoot = log;
            RuntimeRoot = FolderPath.Define(Part.RuntimeRoot);
        }

        public static IShellPaths Default
            => new ShellPaths(Part.ExecutingPart, EnvVars.Common.LogRoot);
    }
}