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
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created(WfStepId id, CorrelationToken ct, FlairKind flair = Created)
            => new WfStepCreated(id, ct, flair);

        /// <summary>
        /// Defines a <see cref='WfStepCreated{T}'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepCreated<T> created<T>(WfStepId id, T content, CorrelationToken ct, FlairKind flair = Created)
            => new WfStepCreated<T>(id, content, ct, flair);

        /// <summary>
        /// Defines a <see cref='ToolCreated'/> event
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="ct"></param>
        /// <param name="flair"></param>
        [MethodImpl(Inline), Op]
        public static ToolCreated created(WfToolId tool, CorrelationToken ct, FlairKind flair = Created)
            => new ToolCreated(tool, ct, flair);
    }
}