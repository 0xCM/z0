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

    partial struct AB
    {
        /// <summary>
        /// Defines a workflow step id
        /// </summary>
        /// <param name="caller">The invoking member</param>
        /// <typeparam name="T">The host type</typeparam>
        [MethodImpl(Inline)]
        public static WfStepId<T> id<T>(T t = default)
            where T : struct, IWfStep<T>
        {
            var type = typeof(T);
            if(type.Tagged<StepAttribute>())
                return new WfStepId<T>(type.Tag<StepAttribute>().Value.Host);
            else
                return WfStepId<T>.Empty;
        }

        /// <summary>
        /// Creates an identifier for a workflow step
        /// </summary>
        /// <param name="host">The reifying type</param>
        [MethodImpl(Inline), Op]
        public static WfStepId id(Type control, Type effect)
            => new WfStepId(control, effect);

        /// <summary>
        /// Creates an identifier for a workflow step
        /// </summary>
        /// <param name="host">The reifying type</param>
        [MethodImpl(Inline), Op]
        public static WfStepId id(Type host)
            => new WfStepId(host, typeof(void));

        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">A corelation token</param>
        /// <param name="ts">The event timestamp</param>
        [MethodImpl(Inline), Op]
        public static WfEventId id(WfStepId step, CorrelationToken ct)
            => new WfEventId(step.Name, ct);

        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="step">The step id</param>
        /// <param name="ct">The correlation token</param>
        /// <typeparam name="E">The reifying event type</typeparam>
        [MethodImpl(Inline)]
        public static WfEventId id<E>(WfStepId step, CorrelationToken ct)
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
        public static WfEventId id<E,S>(CorrelationToken ct, E e = default, S s = default)
            where E : struct, IWfEvent<E>
            where S : struct, IWfStep<S>
                => new WfEventId(typeof(E), id<S>(), ct, now());

        /// <summary>
        /// Creates a workflow event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">The correlation token, if any</param>
        /// <param name="ts">The timestamp which, if unspecified, will default to the event creation time (now)</param>
        [MethodImpl(Inline), Op]
        public static WfEventId id(string name, CorrelationToken ct)
            => new WfEventId(name, ct);
    }
}