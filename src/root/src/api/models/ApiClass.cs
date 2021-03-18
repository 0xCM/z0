//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiClass<K> : IApiClass<ApiClass<K>,K>
        where K : unmanaged
    {
        public K Kind {get;}

        [MethodImpl(Inline)]
        public ApiClass(K id)
            => Kind = id;

        [MethodImpl(Inline)]
        public bool Equals(ApiClass<K> src)
            => Kind.Equals(src.Kind);

        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiClass<K>(K id)
            => new ApiClass<K>(id);

        [MethodImpl(Inline)]
        public static implicit operator K(ApiClass<K> src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator ApiClass(ApiClass<K> src)
            => Root.@as<K,ApiClass>(src.Kind);
    }
}