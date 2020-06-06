//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
        
    public readonly struct DataBroker<K,T> : IDataBroker<K,T>
        where K : unmanaged, Enum
    {
        readonly DataHandler<T>[] handlers;

        readonly IndexFunction<K> xf;

        Span<DataHandler<T>> Handlers
        {
            [MethodImpl(Inline)]
            get => handlers;
        }
        
        [MethodImpl(Inline)]
        public DataBroker(int capacity, IndexFunction<K> xf)
        {
            handlers = new DataHandler<T>[capacity];
            handlers.Fill(DataHandler<T>.Empty);
            this.xf = xf;
        }

        [MethodImpl(Inline)]
        public ref DataHandler<T> Set(K kind, in DataHandler<T> handler)
        {
            var index = xf(kind);
            ref var dst = ref seek(Handlers, index);
            dst = handler;
            return ref dst;            
        }

        [MethodImpl(Inline)]
        public ref readonly DataHandler<T> Get(K kind)
            => ref skip(Handlers, xf(kind));

        public ref DataHandler<T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref seek(Handlers, xf(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, T data)
            => Get(kind).Handle(data);
    }
}