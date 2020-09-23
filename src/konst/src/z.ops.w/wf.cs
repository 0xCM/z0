//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Defines an event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">A corelation token</param>
        /// <param name="ts">The event timestamp</param>
        [MethodImpl(Inline), Op]
        public static WfEventId evid(string name, CorrelationToken ct, Timestamp? ts = null)
            => new WfEventId(name, ct, ts ?? now());
    }
}