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

    [ApiHost]
    public readonly struct WfLogs
    {
        [MethodImpl(Inline), Op]
        public static IWfProcLog process(WfLogConfig config)
            => new WfProcLog(config);

        [MethodImpl(Inline), Op]
        public static IWfEventLog events(WfLogConfig config)
            => new WfEventLog(config);

        [MethodImpl(Inline), Op]
        public static FS.FolderPath root(string area)
            => WfEnv.dbRoot() + FS.folder("logs") + FS.folder(area);

        [MethodImpl(Inline), Op]
        public static WfLogConfig configure(PartId part, FS.FolderPath dbRoot, FS.FolderPath logRoot)
            => new WfLogConfig(part, dbRoot, logRoot);

        [MethodImpl(Inline), Op]
        public static WfLogConfig configure(PartId part, FS.FolderPath dbRoot, string area)
            => new WfLogConfig(part, dbRoot, dbRoot + FS.folder("logs") + FS.folder(area));

        [MethodImpl(Inline), Op]
        public static WfLogConfig configure(PartId part, string area)
            => new WfLogConfig(part, WfEnv.dbRoot(), WfEnv.dbRoot() + FS.folder("logs") + FS.folder(area));

    }
}
