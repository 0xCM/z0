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
        /// Defines a <see cref='CreatingEvent'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static CreatingEvent creating(WfStepId id, CorrelationToken ct)
            => new CreatingEvent(id, ct);

        /// <summary>
        /// Defines a <see cref='CreatedEvent{T}'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CreatingEvent<T> creating<T>(WfStepId id, T content, CorrelationToken ct)
            => new CreatingEvent<T>(id, content, ct);
    }
}