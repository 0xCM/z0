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

    partial struct Flow
    {
        /// <summary>
        /// Creates an event sink that emits persistent log data and renders events to the terminal
        /// </summary>
        /// <param name="log">The persistent target</param>
        /// <param name="ct">The default correlation token</param>
        [MethodImpl(Inline), Op]
        public static IWfEventSink termlog(IWfEventLog log, CorrelationToken ct)
            => new WfTermLog(log,ct);
    }
}