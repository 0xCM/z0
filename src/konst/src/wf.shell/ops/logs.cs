//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        public static IWfEventLog log(WfLogConfig config)
            => new WfEventLog(config);

        [MethodImpl(Inline), Op]
        public static WfLogConfig logConfig(PartId part, FS.FolderPath logRoot, FS.FolderPath dbRoot)
            => new WfLogConfig(part, logRoot, dbRoot);

        [MethodImpl(Inline), Op]
        public static WfLogConfig logConfig(PartId part, FS.FolderPath root)
            => logConfig(part, root, dbRoot());

        [MethodImpl(Inline), Op]
        public static FS.FolderPath logRoot()
            => dbRoot() + FS.folder("logs") + FS.folder("wf");
    }
}