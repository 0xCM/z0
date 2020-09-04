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
        readonly WfDataHandler<T>[] handlers;

        readonly BitField64<K> Bits;

        Span<WfDataHandler<T>> Handlers
        {
            [MethodImpl(Inline)]
            get => handlers;
        }

        [MethodImpl(Inline)]
        internal BitBroker(WfDataHandler<T>[] buffer)
        {
            Bits = default;
            handlers = buffer;
            Handlers.Fill(WfDataHandler<T>.Empty);
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind, WfDataHandler<T>[] buffer)
            : this(buffer)
        {
            Bits = BitFields.bf64(kind);
        }

        [MethodImpl(Inline)]
        public BitBroker(K kind)
            : this(kind, new WfDataHandler<T>[64])
        {

        }

        [MethodImpl(Inline)]
        public ref WfDataHandler<T> Set(K kind, in WfDataHandler<T> handler)
        {
            ref var dst = ref seek(Handlers, Bits.Index(kind));
            dst = handler;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref readonly WfDataHandler<T> Get(K kind)
            => ref skip(Handlers, Bits.Index(kind));

        public ref WfDataHandler<T> this[K kind]
        {
            [MethodImpl(Inline)]
            get => ref seek(Handlers, Bits.Index(kind));
        }

        [MethodImpl(Inline)]
        public void Relay(K kind, T data)
            => Get(kind).Handle(data);
    }
}