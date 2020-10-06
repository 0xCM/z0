//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    partial struct WfEvents
    {
        /// <summary>
        /// Defines a <see cref='CreatedEvent'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static CreatedEvent created(WfStepId id, CorrelationToken ct, FlairKind flair = Created)
            => new CreatedEvent(id, ct, flair);

        /// <summary>
        /// Defines a <see cref='CreatedEvent{T}'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CreatedEvent<T> created<T>(WfStepId id, T content, CorrelationToken ct, FlairKind flair = Created)
            => new CreatedEvent<T>(id, content, ct, flair);

        /// <summary>
        /// Defines a <see cref='ToolCreated'/> event
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="ct"></param>
        /// <param name="flair"></param>
        [MethodImpl(Inline), Op]
        public static ToolCreated created(ToolId tool, CorrelationToken ct, FlairKind flair = Created)
            => new ToolCreated(tool, ct, flair);
    }
}