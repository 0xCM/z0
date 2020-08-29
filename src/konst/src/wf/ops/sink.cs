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
    using static TableFunctions;

    partial struct AB
    {
        /// <summary>
        /// Creates a T-parametric sink predicated on a <see cref='Receive{T}'/> process function
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="f">The process function</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static WfTableSink<T> tablesink<T>(IWfShell wf, Receive<T> f)
            where T : struct, ITable<T>
                => new WfTableSink<T>(wf, f);

        [MethodImpl(Inline), Op]
        public static TermEventSink sink(CorrelationToken? ct = null)
            => new TermEventSink(correlate(ct));

        [MethodImpl(Inline), Op]
        public static WfTermEventSink sink(IWfEventLog log, CorrelationToken ct)
            => WfTermEventSink.create(log, ct);
    }
}