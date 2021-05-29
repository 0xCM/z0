//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ToolEvents
    {
        /// <summary>
        /// Defines a <see cref='ToolRanEvent{T}'/> event indicating failure
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ToolRanEvent fail(ToolExecSpec spec, CorrelationToken ct)
            => new ToolRanEvent(spec, false, ct);

        /// <summary>
        /// Defines a <see cref='ToolRanEvent{T}'/> event indicating failure
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ToolRanEvent<T> fail<T>(ToolExecSpec spec, CorrelationToken ct)
            => new ToolRanEvent<T>(spec, false, default(T), ct);

        /// <summary>
        /// Defines a <see cref='ToolRanEvent{T}'/> event indicating success
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ToolRanEvent ran(ToolExecSpec spec, CorrelationToken ct)
            => new ToolRanEvent(spec, true, ct);

        /// <summary>
        /// Defines a <see cref='ToolRanEvent{T}'/>  event indicating success
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ToolRanEvent<T> ran<T>(ToolExecSpec spec, T payload, CorrelationToken ct)
            => new ToolRanEvent<T>(spec, true, payload, ct);

        [MethodImpl(Inline)]
        public static RanEvent<T> ran<H,T>(H host, T data, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new RanEvent<T>(host.StepId, data, ct);
    }

}