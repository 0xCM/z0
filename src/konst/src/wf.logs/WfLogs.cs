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

    [ApiHost]
    public readonly struct WfLogs
    {
        [Op]
        public static string format(in IWfLogConfig src)
           => string.Format(RP.Settings4,
                nameof(src.LogRoot), src.LogRoot.Format(),
                nameof(src.StatusLog), src.StatusLog.Format(),
                nameof(src.ErrorLog), src.ErrorLog.Format()
                );

        [MethodImpl(Inline), Op]
        public static IWfProcLog process(WfLogConfig config)
            => new WfProcLog(config);

        [MethodImpl(Inline), Op]
        public static IWfEventLog events(WfLogConfig config)
            => new WfEventLog(config);

        [MethodImpl(Inline), Op]
        public static IWfEventSink term(string src)
            => new WfTermLog(src);

        [MethodImpl(Inline), Op]
        public static FS.FolderPath area(FS.FolderPath dbRoot, string area)
            => dbRoot + FS.folder("logs") + FS.folder(area);

        [MethodImpl(Inline), Op]
        public static WfLogConfig configure(PartId part, FS.FolderPath dbRoot)
            => new WfLogConfig(part, dbRoot);

        [MethodImpl(Inline), Op]
        public static WfLogConfig configure(PartId part, FS.FolderPath dbRoot, string area)
            => new WfLogConfig(part, dbRoot);
    }
}