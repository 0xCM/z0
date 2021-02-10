//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Seq;

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        internal static IWfShell clone(IWfShell src, WfHost host, IPolyStream random, LogLevel verbosity)
            => new WfShell(src.Init, src.Ct, src.WfSink, src.Broker, host, random, verbosity, src.Router, src.Services);
    }
}