//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct WfEvents
    {
        /// <summary>
        /// Defines a <see cref='CmdRanEvent{T}'/> event indicating failure
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CmdRanEvent fail(CmdExecSpec spec, CorrelationToken ct)
            => new CmdRanEvent(spec, false, ct);

        /// <summary>
        /// Defines a <see cref='CmdRanEvent{T}'/> event indicating failure
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CmdRanEvent<T> fail<T>(CmdExecSpec spec, CorrelationToken ct)
            => new CmdRanEvent<T>(spec, false, default(T), ct);
    }
}