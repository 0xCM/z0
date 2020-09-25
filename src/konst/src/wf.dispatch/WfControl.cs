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

    [ApiHost]
    public readonly struct WfControl
    {
        /// <summary>
        /// Creates a T-parametric sink predicated on a <see cref='Receive{T}'/> process function
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="f">The process function</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static TableSink<T> sink<T>(IWfShell wf, Receive<T> f)
            where T : struct, ITable<T>
                => new TableSink<T>(wf, f);

        [MethodImpl(Inline)]
        public static WfFunc<H> func<H>([CallerMemberName] string name = null)
            where H : struct, IWfStep<H>
                => new WfFunc<H>(name);

        [MethodImpl(Inline)]
        public static WfFunc<H,T> func<H,T>(H host, T t, [CallerMemberName] string name = null)
            where H : struct, IWfStep<H>
                => new WfFunc<H,T>(name);

        [MethodImpl(Inline)]
        public static WfFunc<H,T> func<H,T>([CallerMemberName] string name = null)
            where H : struct, IWfStep<H>
                => new WfFunc<H,T>(name);

        [MethodImpl(Inline), Op]
        public static WfStepControl step(WfStepId id, Action fx)
            => new WfStepControl(id, fx);

        [MethodImpl(Inline)]
        public static WfStepControl<H> step<H>(Action fx)
            where H : IWfStep<H>, new()
                => new WfStepControl<H>(fx);

        [MethodImpl(Inline)]
        public static DataBroker<K,C,T> broker<K,C,T>(IWfShell wf, int capacity, WfDelegates.Indexer<K> xf)
            where K : unmanaged, Enum
                => new DataBroker<K,C,T>(wf, capacity, xf);

        [MethodImpl(Inline)]
        public static DataBroker<K,T> broker<K,T>(int capacity, WfDelegates.Indexer<K> @if = null)
            where K : unmanaged, Enum
                => new DataBroker<K,T>(capacity, @if ?? Enums.e64u);

        [MethodImpl(Inline), Op]
        public static WfShellHost host(IWfShell wf, WfHost host)
            => (wf,host);

        [MethodImpl(Inline)]
        public static WfShellHost<H> host<H>(IWfShell wf)
            where H : IWfHost<H>, new()
                => new WfShellHost<H>(wf,new H());

        [MethodImpl(Inline)]
        public static WfStepExec<H,T> executor<H,T>(IWfShell wf, WfStepArgs? args = null, WfStepId? id = null)
            where H : struct, IWfStepExec<T>, IWfStep<H>
        {
            var e = new WfStepExec<H,T>(wf, id ?? Flow.step<H>());
            e.Configure(args ?? WfStepArgs.Empty);
            return e;
        }

        [MethodImpl(Inline)]
        public static TableRunner<F,T,D,S,Y> runner<F,T,D,S,Y>(IWfShell wf, TableMaps<D,S,T,Y> processors, TableSectors<D,S> selectors)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T,D>
            where D : unmanaged, Enum
            where S : unmanaged
                => new TableRunner<F,T,D,S,Y>(wf, processors, selectors);
    }
}