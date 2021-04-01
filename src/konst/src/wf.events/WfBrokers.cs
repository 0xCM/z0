//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct WfBrokers
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static WfEventHub hub(int capacity = 128)
            => new WfEventHub(capacity);

        [MethodImpl(Inline), Op]
        public static WfHubClient client(IWfEventHub hub, IDataEventSink sink, Action connect, Action exec)
            => new WfHubClient(hub, sink, connect, exec);

        /// <summary>
        /// Creates a T-parametric sink predicated on a <see cref='ValueReceiver{T}'/> process function
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="f">The process function</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static WfSink<T> sink<T>(IWfShell wf, Receiver<T> f)
            => new WfSink<T>(wf, f);

        [MethodImpl(Inline)]
        public static HubRelay relay(EventReceiver receiver)
            => new HubRelay(receiver);

        [MethodImpl(Inline)]
        public static HubRelay<E> relay<E>(EventReceiver<E> receiver)
            where E : struct, IDataEvent
                => new HubRelay<E>(receiver);

        [MethodImpl(Inline)]
        public static ref readonly E broadcast<E>(WfEventHub hub, in E e)
            where E : struct, IDataEvent
        {
            if(hub.Index.TryGetValue(e.GetType(), out var sink))
                sink.Deposit(e);
            return ref e;
        }

        [MethodImpl(Inline)]
        public static bool subscribe<E>(WfEventHub hub, EventReceiver receiver, E model = default)
            where E : struct, IDataEvent
                => subscribe(hub, new HubRelay(receiver), model);

        [MethodImpl(Inline), Op]
        public static bool subscribe(WfEventHub hub, EventReceiver receiver, IDataEvent model)
            => hub.Index.TryAdd(model.GetType(), new HubRelay(receiver));

        [MethodImpl(Inline)]
        public static bool subscribe<S,E>(WfEventHub hub, S sink, E model)
            where E : struct, IDataEvent
            where S : IDataEventSink
                => hub.Index.TryAdd(typeof(E), sink);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataHandler<T> handler<T>(DataReceiver<T> receiver)
            => new DataHandler<T>(receiver);
    }
}