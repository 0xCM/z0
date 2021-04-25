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

    [ApiHost]
    public readonly struct ApiKeys
    {
        [MethodImpl(Inline), Op]
        public static ApiKey key(PartId part, ushort host, ApiClass @class)
        {
            var dst = span16u(Cells.alloc(w128).Bytes);
            seek(dst,0) = (ushort)part;
            seek(dst,1) = host;
            seek(dst,2) = @class;
            return key(dst);
        }

        [MethodImpl(Inline), Op]
        public static ApiKey key(PartId part, ushort host, ApiClass @class, params ushort[] data)
        {
            var dst = span16u(Cells.alloc(w128).Bytes);
            seek(dst,0) = (ushort)part;
            seek(dst,1) = host;
            seek(dst,2) = @class;
            var src = @readonly(data);
            for(var i=3; i<data.Length + 3; i++)
                seek(dst,i) = skip(src,i);
            return key(dst);
        }

        [MethodImpl(Inline), Op]
        public static ApiKey key(ReadOnlySpan<byte> src)
            => new ApiKey(src);

        [MethodImpl(Inline), Op]
        public static ApiKey key(ReadOnlySpan<ushort> src)
            => new ApiKey(src);

        [MethodImpl(Inline), Op]
        public static ApiKey key(ReadOnlySpan<ApiKeyPart> src)
            => new ApiKey(src);

        [MethodImpl(Inline), Op]
        public static ApiKeyPart part(ReadOnlySpan<byte> src)
            => first(span16u(src));

        [MethodImpl(Inline), Op]
        public static ApiKeyJoin join(ReadOnlySpan<byte> src)
            => first(span32u(src));

        [MethodImpl(Inline), Op]
        public static ApiKeyPart part(ushort src)
            => new ApiKeyPart(src);

        [MethodImpl(Inline)]
        public static ApiKeyPart part(ApiKey src, byte index)
            => cpu.vextract(src.V16u, index);

        [MethodImpl(Inline), Op]
        public static ApiKey part(ApiKey src, byte index, ApiKeyPart value)
            => new ApiKey(cpu.vinsert(value, src.V16u, index));

        [MethodImpl(Inline), Op]
        public static ApiKeyJoin join(uint src)
        {
            var left = (ushort)(src & ushort.MaxValue);
            var right = (ushort)(src >> 16);
            return new ApiKeyJoin(left,right);
        }

        [MethodImpl(Inline), Op]
        public static ApiKeyJoin join(ApiKey src, byte i, byte j)
        {
            var m = mask(ApiKey.W, i, j);
            var a = cpu.vshuf16x8(src.V8u, m);
            var b = cpu.v32u(a);
            var d = cpu.vextract(b,0);
            return join(d);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> data(ApiKey src)
        {
            var dst = Cells.alloc(ApiKey.W);
            gcpu.vstore(src.V8u, ref dst);
            return dst.Bytes;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> data(ApiKeyJoin src)
            => bytes(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> data(ApiKeyPart src)
            => bytes(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(ApiKeyPart src)
        {
            ushort data = src;
            return Hex.chars(LowerCase, data);
        }

        [MethodImpl(Inline), Op]
        public static void render(ApiKeyPart src, Span<char> dst)
        {
            ushort data = src;
            Hex.chars(LowerCase, data, dst, 0);
        }

        [MethodImpl(Inline), Op]
        public static K kind<K>(ApiKey src)
            => @as<ApiKeyPart,K>(src.Part(n2));

        [MethodImpl(Inline), Op]
        public static ApiKey<K> kind<K>(K kind, ApiKey src)
            where K : unmanaged
                => part(src, 2, part(bw16(kind)));

        [MethodImpl(Inline), Op]
        internal static Vector128<byte> mask(W128 w, byte i, byte j)
        {
            var storage = recover<ushort>(Cells.alloc(w).Bytes);
            seek(storage, i) = ushort.MaxValue;
            seek(storage, j) = ushort.MaxValue;
            return cpu.vload(w, recover<byte>(storage));
        }
    }
}