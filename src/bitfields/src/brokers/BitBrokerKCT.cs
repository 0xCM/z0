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

    /// <summary>
    /// Mediates parametric data exchange for up to 64 enumeration-predicated classifiers
    /// </summary>
    public readonly struct BitBroker<K,C,T> : IDataProcessor<T>, IDataBroker<K,C,T>
        where K : unmanaged, Enum
    {
        readonly DataHandler<C,T>[] handlers;

        readonly BitField64<K> Bits;

        Span<DataHandler<C,T>> Handlers
        {
            [MethodImpl(Inline)]
            get => handlers;
        }

        [MethodImpl(Inline)]
        public BitBroker(DataHandler<C,T>[] buffer)
        {
            Bits = default;
            handlers = buffer;
            Handlers.Fill(DataHandler<C,T>.Empty);
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind, DataHandler<C,T>[] buffer)
            : this(buffer)
        {
            Bits = BitFields.bf64(kind);
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind)
            : this(kind, new DataHandler<C,T>[64])
        {

        }

        [MethodImpl(Inline)]
        public ref DataHandler<C,T> Set(K kind, in DataHandler<C,T> handler)
        {
            ref var dst = ref seek(Handlers, Bits.Index(kind));
            dst = handler;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref readonly DataHandler<C,T> Get(K kind)
            => ref skip(Handlers, Bits.Index(kind));

        public ref DataHandler<C,T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref seek(Handlers, Bits.Index(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, C context, T data)
            => Get(kind).Handle(context, data);
    }
}