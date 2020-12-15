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
    public readonly struct BitBroker<K,T> : IWfDataProcessor<T>, IWfDataBroker<K,T>
        where K : unmanaged, Enum
    {
        readonly DataHandler<T>[] _Handlers;

        readonly BitField64<K> Bits;

        Span<DataHandler<T>> Handlers
        {
            [MethodImpl(Inline)]
            get => _Handlers;
        }

        [MethodImpl(Inline)]
        internal BitBroker(DataHandler<T>[] buffer)
        {
            Bits = default;
            _Handlers = buffer;
            Handlers.Fill(DataHandler<T>.Empty);
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind, DataHandler<T>[] buffer)
            : this(buffer)
        {
            Bits = BitFields.bf64(kind);
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind)
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

        public void Process(T src)
        {
            ref readonly var handlers = ref first(_Handlers);
            for(var i=0; i<_Handlers.Length; i++)
                skip(handlers,i).Handle(src);
        }
    }
}