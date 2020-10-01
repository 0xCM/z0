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

    partial struct WfCore
    {
        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="step">The step id</param>
        /// <param name="ct">The correlation token</param>
        /// <typeparam name="E">The reifying event type</typeparam>
        [MethodImpl(Inline)]
        public static WfEventId @event<E>(WfStepId step, CorrelationToken ct)
            where E : struct, IWfEvent<E>
                => new WfEventId(typeof(E), step, ct);

        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="step">The step id</param>
        /// <param name="ct">The correlation token</param>
        /// <typeparam name="E">The reifying event type</typeparam>
        /// <typeparam name="S">The workflow controller type</typeparam>
        [MethodImpl(Inline)]
        public static WfEventId @event<E,S>(CorrelationToken ct, E e = default, S s = default)
            where E : struct, IWfEvent<E>
            where S : struct, IWfStep<S>
                => new WfEventId(typeof(E), step<S>(), ct, now());

        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">A corelation token</param>
        /// <param name="ts">The event timestamp</param>
        [MethodImpl(Inline), Op]
        public static WfEventId @event(WfStepId step, CorrelationToken ct)
            => new WfEventId(step.Name, ct);

        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">A corelation token</param>
        /// <param name="ts">The event timestamp</param>
        [MethodImpl(Inline), Op]
        public static WfEventId @event(Type type, WfStepId step, CorrelationToken ct)
            => new WfEventId(type, step,  ct);

        /// <summary>
        /// Creates a workflow event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">The correlation token, if any</param>
        /// <param name="ts">The timestamp which, if unspecified, will default to the event creation time (now)</param>
        [MethodImpl(Inline), Op]
        public static WfEventId @event(string name, CorrelationToken ct)
            => new WfEventId(name, ct);

        [MethodImpl(Inline)]
        public static WfEventId @event<C>(WfFunc<C> fx, CorrelationToken ct)
            where C : struct, IWfStep<C>
                => new WfEventId(fx,ct);

        [MethodImpl(Inline)]
        public static WfEventId @event<C,R>(WfFunc<C,R> fx, CorrelationToken ct)
            where C : struct, IWfStep<C>
            where R : ITextual
                => new WfEventId(fx,ct);
    }
}