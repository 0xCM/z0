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
        readonly DataHandler<T>[] _Handlers;

        readonly K Bits;

        Span<DataHandler<T>> Handlers
        {
            [MethodImpl(Inline)]
            get => _Handlers;
        }

        [MethodImpl(Inline)]
        internal BitBroker(DataHandler<T>[] handlers)
        {
            Bits = default;
            _Handlers = handlers;
            Handlers.Fill(DataHandler<T>.Empty);
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind, DataHandler<T>[] handlers)
            : this(handlers)
        {
            Bits = kind;
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind)
            : this(kind, new DataHandler<T>[64])
        {

        }

        [MethodImpl(Inline)]
        static byte Index(K src)
            => (byte)Pow2.log2(uint64(src));

        [MethodImpl(Inline)]
        public ref readonly DataHandler<T> Get(K kind)
            => ref skip(Handlers, Index(kind));

        public ref DataHandler<T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref seek(Handlers, Index(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, T data)
            => Get(kind).Handle(data);

        public void Process(T src)
        {
            ref readonly var handlers = ref first(_Handlers);
            for(var i=0; i<_Handlers.Length; i++)
                skip(handlers,i).Handle(src);
        }
    }
}