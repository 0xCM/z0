//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct WfShell
    {
        [MethodImpl(Inline), Op]
        public static IWfPaths paths(FS.FolderPath root)
            => new WfPaths(root);

        [MethodImpl(Inline), Op]
        public static IWfPaths paths()
            => new WfPaths(EnvVars.Common.LogRoot);
    }
}