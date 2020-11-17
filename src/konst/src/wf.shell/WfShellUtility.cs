//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    readonly struct WfShellUtility
    {
        [MethodImpl(Inline), Op]
        public static IWfShell clone(IWfShell src, WfHost host, IPolyrand random, LogLevel verbosity)
            => new WfShell(src.Init, src.Ct, src.WfSink, src.Broker, host, random, verbosity);
    }
}