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
        /// Defines a <see cref='DisposedEvent'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        [MethodImpl(Inline), Op]
        public static DisposedEvent disposed(WfStepId step, CorrelationToken ct)
            => new DisposedEvent(step,ct);

        /// <summary>
        /// Defines a <see cref='Disposed{T}'/> event that carries a specified payload
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="payload">The payload data</param>
        /// <param name="ct">The correlation token</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Disposed<T> disposed<T>(WfStepId step, T payload, CorrelationToken ct)
            => new Disposed<T>(step,payload,ct);
    }
}