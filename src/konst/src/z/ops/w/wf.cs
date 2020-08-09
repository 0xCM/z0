//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Defines an actor with a specified name, if given; otherwise the actor name is derived 
        /// from the path of the invoking member file
        /// </summary>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WfActor actor([CallerFilePath] string name = null)
            => WfActor.create(name);

        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">A corelation token</param>
        /// <param name="ts">The event timestamp</param>
        [MethodImpl(Inline), Op]
        public static WfEventId evid(string name, CorrelationToken ct, Timestamp? ts = null)
            => new WfEventId(name, ct, ts ?? now());

        /// <summary>
        /// Defines a workflow step identifier
        /// </summary>
        /// <param name="kind">The step classifier</param>
        /// <param name="actor">The actor</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op]
        public static WfStepId step<T>(T kind, [CallerFilePath] string actor = null)
            where T : unmanaged, Enum
                => new WfStepId(uint64<T>(kind), Path.GetFileNameWithoutExtension(actor));
    }
}