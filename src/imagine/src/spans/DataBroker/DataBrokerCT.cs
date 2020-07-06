//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
        
    public readonly struct DataBroker<K,C,T> : IDataBroker<K,C,T>
        where K : unmanaged, Enum
    {
        readonly DataHandler<C,T>[] handlers;

        readonly IndexFunction<K> xf;

        Span<DataHandler<C,T>> Handlers
        {
            [MethodImpl(Inline)]
            get => handlers;
        }
        
        [MethodImpl(Inline)]
        public DataBroker(int capacity, IndexFunction<K> xf)
        {
            handlers = new DataHandler<C,T>[capacity];
            handlers.Fill(DataHandler<C,T>.Empty);
            this.xf = xf;
        }

        [MethodImpl(Inline)]
        public ref DataHandler<C,T> Set(K kind, in DataHandler<C,T> handler)
        {
            var index = xf(kind);
            ref var dst = ref seek(Handlers, index);
            dst = handler;
            return ref dst;            
        }

        [MethodImpl(Inline)]
        public ref readonly DataHandler<C,T> Get(K kind)
            => ref skip(Handlers, xf(kind));

        public ref DataHandler<C,T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref seek(Handlers, xf(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, C context, T data)
            => Get(kind).Handle(context,data);
    }
}