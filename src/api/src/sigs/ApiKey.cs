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

    using static Root;
    using static core;

    using api = ApiKeys;

    /// <summary>
    /// Defines a 128-bit bitfield that identifies an api operation along with its operands
    /// </summary>
    /// <remarks>
    /// [ Operands              | ApiClass  | Host | Component ]
    /// [ 7 | 6 | 5 | 4 | 3     | 2         | 1    | 0         ]
    /// </remarks>
    [ApiComplete]
    public readonly struct ApiKey
    {
        public static W128 W => default;

        readonly Vector128<byte> Storage;

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<byte> src)
            => Storage = cpu.vload(W,src);

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<ushort> src)
            => Storage = cpu.v8u(cpu.vload(W,src));

        [MethodImpl(Inline)]
        public ApiKey(ReadOnlySpan<ApiKeyPart> src)
            => Storage = cpu.vload(W,bytes(src));

        [MethodImpl(Inline)]
        internal ApiKey(Vector128<ushort> src)
            => Storage = cpu.v8u(src);

        [MethodImpl(Inline)]
        internal ApiKey(Vector128<byte> src)
            => Storage = src;

        public DataWidth Width
            => DataWidth.W128;

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => api.data(this);
        }

        [MethodImpl(Inline)]
        public ApiKeyJoin Join(byte i, byte j)
            => api.join(this, i, j);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N0 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N1 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N2 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N3 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N4 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N5 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N6 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKeyPart Part(N7 n)
            => api.part(this, n);

        [MethodImpl(Inline)]
        public ApiKey Part(N0 n, ApiKeyPart value)
            => api.part(this, 0, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N1 n, ApiKeyPart value)
            => api.part(this, 1, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N2 n, ApiKeyPart value)
            => api.part(this, 2, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N3 n, ApiKeyPart value)
            => api.part(this, 3, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N4 n, ApiKeyPart value)
            => api.part(this, 4, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N5 n, ApiKeyPart value)
            => api.part(this, 5, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N6 n, ApiKeyPart value)
            => api.part(this, 6, value);

        [MethodImpl(Inline)]
        public ApiKey Part(N7 n, ApiKeyPart value)
            => api.part(this, 7, value);

        internal Vector128<byte> V8u
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        internal Vector128<ushort> V16u
        {
            [MethodImpl(Inline)]
            get => gcpu.v16u(Storage);
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

        public static ApiKey Empty => default;
    }
}