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

    public readonly struct DataBroker<K,T> : IWfDataBroker<K,T>
        where K : unmanaged
    {
        readonly TableSpan<DataHandler<T>> Data;

        readonly WfDelegates.Indexer<K> Indexer;

        Span<DataHandler<T>> Handlers
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        [MethodImpl(Inline)]
        public DataBroker(int capacity, WfDelegates.Indexer<K> xf)
        {
            Data = new DataHandler<T>[capacity];
            Data.Edit.Fill(DataHandler<T>.Empty);
            Indexer = xf;
        }

        [MethodImpl(Inline)]
        public ref DataHandler<T> Set(K kind, in DataHandler<T> handler)
        {
            var index = Indexer(kind);
            ref var dst = ref seek(Handlers, index);
            dst = handler;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref readonly DataHandler<T> Get(K kind)
            => ref skip(Handlers, Indexer(kind));

        public ref DataHandler<T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref seek(Handlers, Indexer(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, T data)
            => Get(kind).Handle(data);
    }
}