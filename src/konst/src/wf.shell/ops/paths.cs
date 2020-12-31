//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        public static IWfAppPaths paths()
            => new WfPaths(WfEnv.dbRoot());

        [MethodImpl(Inline), Op]
        public static IWfAppPaths paths(FS.FolderPath root)
            => new WfPaths(root);

        [MethodImpl(Inline), Op]
        public static IWfAppPaths paths<A>()
            => new WfPaths(WfEnv.dbRoot() + FS.folder(controller<A>().Id().Format()));
    }
}