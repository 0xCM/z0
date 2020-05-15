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
        
    public readonly struct DataBroker<E,T> : IDataBroker<E,T>
        where E : unmanaged, Enum
    {
        readonly DataHandler<T>[] Handlers;

        readonly IndexFunction<E> If;
        
        internal DataBroker(int capacity, IndexFunction<E> @if)
        {
            Handlers = new DataHandler<T>[capacity];
            Handlers.Fill(DataHandler<T>.Empty);
            If = @if;
        }

        [MethodImpl(Inline)]
        public void Set(E index, DataHandler<T> handler)
            => Handlers[If(index)] = handler;

        [MethodImpl(Inline)]
        public DataHandler<T> Get(E kind)
            => Handlers[If(kind)];

        public DataHandler<T> this[E kind]
        {
            [MethodImpl(Inline)]
            get => Get(kind);

            [MethodImpl(Inline)]
            set => Set(kind,value);
        }

        [MethodImpl(Inline)]
        public void Relay(E kind, T data)
            => this[kind].Handle(data);
    }
}