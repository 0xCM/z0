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
        public K ClassId {get;}

        [MethodImpl(Inline)]
        public ApiClass(K id)
            => ClassId = id;

        [MethodImpl(Inline)]
        public bool Equals(ApiClass<K> src)
            => ClassId.Equals(src.ClassId);

        public string Format()
            => ClassId.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiClass<K>(K id)
            => new ApiClass<K>(id);

        [MethodImpl(Inline)]
        public static implicit operator K(ApiClass<K> src)
            => src.ClassId;

        [MethodImpl(Inline)]
        public static implicit operator ApiClass(ApiClass<K> src)
            => Root.@as<K,ApiClass>(src.ClassId);
    }
}