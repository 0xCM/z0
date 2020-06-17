//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    /// <summary>
    /// Mediates parametric data exchange for up to 64 enumeration-predicated classifiers
    /// </summary>
    public readonly struct DataBroker64<K,T> : IDataBroker<K,T>
        where K : unmanaged, Enum
    {
        readonly DataHandler<T>[] handlers;

        readonly BitField64<K> Bits;

        Span<DataHandler<T>> Handlers
        {
            [MethodImpl(Inline)]
            get => handlers;
        }

        [MethodImpl(Inline)]
        DataBroker64(DataHandler<T>[] buffer)
        {
            Bits = default;
            handlers = buffer;
            Handlers.Fill(DataHandler<T>.Empty);            
        }

        [MethodImpl(Inline)]
        public DataBroker64(K kind, DataHandler<T>[] buffer)
            : this(buffer)
        {
            Bits = BitFields.bf64(kind);
        }

        [MethodImpl(Inline)]
        public DataBroker64(K kind)
            : this(kind, new DataHandler<T>[64])
        {
            
        }        
        
        [MethodImpl(Inline)]
        public ref DataHandler<T> Set(K kind, in DataHandler<T> handler)
        {
            ref var dst = ref seek(Handlers, Bits.Index(kind));
            dst = handler;
            return ref dst;            
        }

        [MethodImpl(Inline)]
        public ref readonly DataHandler<T> Get(K kind)
            => ref skip(Handlers, Bits.Index(kind));

        public ref DataHandler<T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref seek(Handlers, Bits.Index(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, T data)
            => Get(kind).Handle(data);
    }
}