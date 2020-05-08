//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IDataBroker
    {
        
    }

    public interface IDataBroker<T> : IDataBroker
    {

    }

    public interface IHandlerIndex
    {

    }
    
    public interface IHandlerIndex<E> : IHandlerIndex
        where E : unmanaged, Enum
    {

        
    }

    public interface IDataBroker<E,T> : IDataBroker<T>, IHandlerIndex<E>
        where E : unmanaged, Enum
    {

    }

    public readonly struct DataBroker64<E,T> : IDataBroker<E,T>
        where E : unmanaged, Enum
    {
        readonly DataHandler<T>[] Handlers;

        readonly BitField64<E> Bits;

        public static DataBroker64<E,T> Alloc()
            => new DataBroker64<E,T>(default(E));        

        [MethodImpl(Inline)]
        DataBroker64(E kind)
        {
            Bits = BitField64.init(kind);
            Handlers = new DataHandler<T>[64];
            Handlers.Fill(DataHandler<T>.Empty);
        }        
        
        [MethodImpl(Inline)]
        public void Set(E kind, DataHandler<T> handler)
            => Handlers[Bits.Index(kind)] = handler;

        [MethodImpl(Inline)]
        public DataHandler<T> Get(E kind)
            => Handlers[Bits.Index(kind)];

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