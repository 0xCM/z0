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

    [ApiComplete]
    public struct ApiKey
    {
        public static W128 W => default;

        internal Vector128<byte> Storage;

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<byte> src)
            => Storage = cpu.vload(W,src);

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<ApiKeyPart> src)
            => Storage = cpu.vload(W,bytes(src));

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => api.data(this);
        }

        public DataWidth Width => DataWidth.W128;

        [MethodImpl(Inline)]
        public ApiKeyJoin Join(byte i, byte j)
            => api.join(this,i,j);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N0 n)
            => Part(0);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N1 n)
            => Part(1);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N2 n)
            => Part(2);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N3 n)
            => Part(3);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N4 n)
            => Part(4);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N5 n)
            => Part(5);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N6 n)
            => Part(6);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N7 n)
            => Part(7);

        [MethodImpl(Inline)]
        public ApiKey Part(N0 n, ApiKeyPart value)
            => Part(0, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N1 n, ApiKeyPart value)
            => Part(1, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N2 n, ApiKeyPart value)
            => Part(2, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N3 n, ApiKeyPart value)
            => Part(3, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N4 n, ApiKeyPart value)
            => Part(4, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N5 n, ApiKeyPart value)
            => Part(5, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N6 n, ApiKeyPart value)
            => Part(6, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N7 n, ApiKeyPart value)
            => Part(7, value);

        internal Vector128<ushort> D16u
        {
            [MethodImpl(Inline)]
            get => gcpu.v16u(Storage);
        }

        [MethodImpl(Inline)]
        internal ApiKeyPart Part(byte index)
            => cpu.vextract(D16u, index);

        [MethodImpl(Inline)]
        internal ApiKey Part(byte index, ApiKeyPart value)
        {
            cpu.vinsert(value, D16u, index);
            return this;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiKey(ReadOnlySpan<byte> src)
            => new ApiKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(ApiKey src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiKey(ReadOnlySpan<ApiKeyPart> src)
            => new ApiKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiKey(Span<byte> src)
            => new ApiKey(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiKey(Span<ApiKeyPart> src)
            => new ApiKey(src);
    }
}