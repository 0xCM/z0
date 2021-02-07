//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct Loggers
    {
        [Op]
        public static string format(IWfLogConfig src)
           => string.Format(RP.Settings4,
                nameof(src.LogRoot), src.LogRoot.Format(),
                nameof(src.StatusLog), src.StatusLog.Format(),
                nameof(src.ErrorLog), src.ErrorLog.Format()
                );

        [MethodImpl(Inline), Op]
        public static IWorkerLog worker(WfLogConfig config)
            => new WorkerLog(config);

        [MethodImpl(Inline), Op]
        public static IWfEventLog events(WfLogConfig config)
            => new WfEventLog(config);

        [MethodImpl(Inline), Op]
        public static IWfEventSink term(string src)
            => new TermLog(src);

        [Op]
        public static ICaseLog cases(FS.FilePath dst)
            => new CaseLog(cases<TestCaseField,TestCaseRecord>(dst));
        [Op]
        public static IBuildLog build(FS.FilePath dst)
            => new BuildLog(dst);

        [MethodImpl(Inline), Op]
        public static WfLogConfig configure(PartId part, FS.FolderPath dbRoot)
            => new WfLogConfig(part, dbRoot);

        [MethodImpl(Inline), Op]
        public static WfLogConfig configure(PartId part, FS.FolderPath dbRoot, string area)
            => new WfLogConfig(part, dbRoot);

        [MethodImpl(Inline)]
        static CaseLog<F,T> cases<F,T>(FS.FilePath dst)
            where T : struct, ITabular
            where F : unmanaged, Enum
                => new CaseLog<F,T>(dst);
    }
}