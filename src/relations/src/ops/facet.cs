//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct Relations
    {
        [MethodImpl(Inline)]
        public static Facet<K,V> facet<K,V>(K key, V value)
            => new Facet<K,V>(key,value);

        [MethodImpl(Inline)]
        public static Facet<S,T> facet<S,T>(Arrow<S,T> src)
            => facet(src.Source, src.Target);
    }
}