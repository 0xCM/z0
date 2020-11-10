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
    /// Defines kinded link
    /// </summary>
    public readonly struct Link<K,S,T>
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
        public Link(K kind, S src, T dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        public static Type Type
            => LinkType<K,S,T>.Type;

        [MethodImpl(Inline)]
        public static implicit operator Link<K,S,T>((K kind, S client, T supplier) x)
            => new Link<K,S,T>(x.kind, x.client, x.supplier);

        [MethodImpl(Inline)]
        public static implicit operator Link<K,S,T>(Tripled<K,S,T> src)
            => new Link<K,S,T>(src.First, src.Second, src.Third);

        [MethodImpl(Inline)]
        public static implicit operator Tripled<K,S,T>(Link<K,S,T> x)
            => (x.Kind, x.Source, x.Target);
    }
}