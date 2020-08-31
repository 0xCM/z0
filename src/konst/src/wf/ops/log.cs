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

    partial struct AB
    {
        [MethodImpl(Inline), Op]
        public static IWfEventLog log(in WfConfig config, CorrelationToken ct, bool clear = true)
            => new WfEventLog(config.StatusLog, config.ErrorLog, termlog(config,clear), ct);

        [MethodImpl(Inline), Op]
        public static IWfEventLog termlog(FS.FilePath status, FS.FilePath error, bool clear = true)
            => new WfTermEventLog(FilePath.Define(status.Name), FilePath.Define(error.Name), clear);

        [MethodImpl(Inline), Op]
        public static IWfEventLog termlog(WfConfig config, bool clear = true)
            => new WfTermEventLog(FilePath.Define(config.StatusLog.Name), FilePath.Define(config.ErrorLog.Name), clear);
    }
}