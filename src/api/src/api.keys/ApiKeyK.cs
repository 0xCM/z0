//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    using api = ApiKeys;

    public struct ApiKey<K>
        where K : unmanaged
    {
        public static W128 W => default;

        internal ApiKey Storage;

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<byte> src)
            => Storage = src;

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<ApiKeyPart> src)
            => Storage = src;

        public ApiClassKind Class
        {
            [MethodImpl(Inline)]
            get => api.@class(Storage);
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiKey(ApiKey<K> src)
            => src.Storage;
    }
}