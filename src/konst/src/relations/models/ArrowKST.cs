//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an arrow with kind
    /// </summary>
    public readonly struct Arrow<K,S,T>
        where K : unmanaged
    {
        /// <summary>
        /// The source
        /// </summary>
        public S Source {get;}

        /// <summary>
        /// The target
        /// </summary>
        public T Target {get;}

        /// <summary>
        /// The kind classifier
        /// </summary>
        public K Kind {get;}

        [MethodImpl(Inline)]
        public Arrow(K kind, S src, T dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        public static Type Type
            => FlowType<K,S,T>.Type;

        [MethodImpl(Inline)]
        public static implicit operator Arrow<K,S,T>((K kind, S client, T supplier) x)
            => new Arrow<K,S,T>(x.kind, x.client, x.supplier);

        [MethodImpl(Inline)]
        public static implicit operator Arrow<K,S,T>(Tripled<K,S,T> src)
            => new Arrow<K,S,T>(src.First, src.Second, src.Third);

        [MethodImpl(Inline)]
        public static implicit operator Tripled<K,S,T>(Arrow<K,S,T> x)
            => (x.Kind, x.Source, x.Target);
    }
}