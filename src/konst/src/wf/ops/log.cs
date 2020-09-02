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

    partial struct AB
    {
        [MethodImpl(Inline), Op]
        public static IMultiSink sink()
            => new TermEventSink();

        [MethodImpl(Inline), Op]
        public static IWfEventLog log(WfConfig config, bool clear = true)
            => new WfTermEventLog(FilePath.Define(config.StatusPath.Name), FilePath.Define(config.ErrorPath.Name), clear);

        [MethodImpl(Inline), Op]
        public static IWfEventLog log(FS.FilePath status, FS.FilePath error, bool clear = true)
            => new WfTermEventLog(FilePath.Define(status.Name), FilePath.Define(error.Name), clear);
    }
}