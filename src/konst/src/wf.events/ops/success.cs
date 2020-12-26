//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        /// <summary>
        /// Defines a <see cref='CmdRanEvent{T}'/> event indicating success
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CmdRanEvent success(CmdSpec spec, CorrelationToken ct)
            => new CmdRanEvent(spec, true, ct);

        /// <summary>
        /// Defines a <see cref='CmdRanEvent{T}'/>  event indicating success
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CmdRanEvent<T> success<T>(CmdSpec spec, T payload, CorrelationToken ct)
            => new CmdRanEvent<T>(spec, true, payload, ct);
    }
}