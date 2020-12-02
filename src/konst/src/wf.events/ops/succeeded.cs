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
        /// Defines a <see cref='CmdSucceeded{T}'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CmdSucceededEvent succeeded(CmdSpec spec, CorrelationToken ct)
            => new CmdSucceededEvent(spec, ct);

        /// <summary>
        /// Defines a <see cref='CmdSucceeded{T}'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static CmdSucceeded<T> succeeded<T>(CmdSpec spec, T payload, CorrelationToken ct)
            => new CmdSucceeded<T>(spec, payload, ct);
    }
}