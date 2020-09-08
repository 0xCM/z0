//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataBroker<K,T> : IWfDataBroker<K,T>
        where K : unmanaged, Enum
    {
        readonly WfDataHandler<T>[] handlers;

        readonly WfDelegates.Indexer<K> xf;

        Span<WfDataHandler<T>> Handlers
        {
            [MethodImpl(Inline)]
            get => handlers;
        }

        [MethodImpl(Inline)]
        public DataBroker(int capacity, WfDelegates.Indexer<K> xf)
        {
            handlers = new WfDataHandler<T>[capacity];
            handlers.Fill(WfDataHandler<T>.Empty);
            this.xf = xf;
        }

        [MethodImpl(Inline)]
        public ref WfDataHandler<T> Set(K kind, in WfDataHandler<T> handler)
        {
            var index = xf(kind);
            ref var dst = ref z.seek(Handlers, index);
            dst = handler;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref readonly WfDataHandler<T> Get(K kind)
            => ref z.skip(Handlers, xf(kind));

        public ref WfDataHandler<T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Handlers, xf(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, T data)
            => Get(kind).Handle(data);
    }
}