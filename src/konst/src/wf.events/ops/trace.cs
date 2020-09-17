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
        /// Creates a <see cref='WfTrace{T}'/> message
        /// </summary>
        /// <param name="step">The executing step</param>
        /// <param name="content">The status content</param>
        /// <param name="ct">The correlation token</param>
        /// <typeparam name="T">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfTrace<T> trace<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfTrace<T>(step, content, ct);
    }
}