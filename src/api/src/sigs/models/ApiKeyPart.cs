//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = ApiKeys;

    public readonly struct ApiKeyPart
    {
        readonly ushort Storage;

        [MethodImpl(Inline)]
        public ApiKeyPart(ushort data)
            => Storage = data;

        public DataWidth Width => DataWidth.W16;

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => api.data(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiKeyPart(ReadOnlySpan<byte> src)
            => api.part(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(ApiKeyPart src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiKeyPart(ushort src)
            => new ApiKeyPart(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(ApiKeyPart src)
            => src.Storage;
    }
}