//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct BitBrokers
    {
        [MethodImpl(Inline)]
        public static BitBroker<K,T> broker64<K,T>(K kind = default, T rep = default)
            where K : unmanaged, Enum
                => new BitBroker<K,T>(kind);
    }

    /// <summary>
    /// Mediates parametric data exchange for up to 64 enumeration-predicated classifiers
    /// </summary>
    public readonly struct BitBroker<K,T> : IWfDataProcessor<T>, IWfDataBroker<K,T>
        where K : unmanaged, Enum
    {
        const byte Slots = 64;

        readonly Index<DataHandler<T>> Handlers;

        readonly K Bits;

        [MethodImpl(Inline)]
        internal BitBroker(DataHandler<T>[] handlers)
        {
            Bits = default;
            Handlers = handlers;
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind, DataHandler<T>[] handlers)
            : this(handlers)
        {
            Bits = kind;
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind)
            : this(kind, new DataHandler<T>[Slots])
        {

        }

        [MethodImpl(Inline)]
        public ref readonly DataHandler<T> Get(K kind)
            => ref this[kind];

        public ref DataHandler<T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref Handlers[Pow2.log2(uint64(kind))];
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, T data)
            => Get(kind).Handle(data);

        public void Process(T src)
        {
            var count = Handlers.Length;
            ref readonly var handlers = ref Handlers.First;
            for(var i=0; i<count; i++)
                skip(handlers,i).Handle(src);
        }
    }
}