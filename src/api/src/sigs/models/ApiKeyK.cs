//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = ApiKeys;

    public readonly struct ApiKey<K>
        where K : unmanaged
    {
        public static W128 W => default;

        readonly ApiKey Storage;

        [MethodImpl(Inline)]
        public ApiKey(ApiKey src)
            => Storage = src;

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<byte> src)
            => Storage = src;

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<ApiKeyPart> src)
            => Storage = src;

        public K Kind
        {
            [MethodImpl(Inline)]
            get => api.kind<K>(Storage);
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiKey(ApiKey<K> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator ApiKey<K>(ApiKey src)
            => new ApiKey<K>(src);
    }
}