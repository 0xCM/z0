//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfLogs
    {
        /// <summary>
        /// Creates an event sink that emits persistent log data and renders events to the terminal
        /// </summary>
        /// <param name="log">The persistent target</param>
        /// <param name="ct">The default correlation token</param>
        [MethodImpl(Inline), Op]
        public static IWfEventSink termlog(IWfEventLog log, CorrelationToken ct)
            => new WfTermLog(log,ct);

        [MethodImpl(Inline), Op]
        public static IWfEventLog events(WfLogConfig config)
            => new WfEventLog(config);

        [Op]
        public static IAppMsgLog app(FilePath std, FilePath err)
            => new AppMsgLog(std, err);

        [Op]
        public static CaseLog caselog(FS.FilePath dst)
            => new CaseLog(new CaseLog<TestCaseField,TestCaseRecord>(dst));
    }
}