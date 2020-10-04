//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public readonly struct TextEncoderKinds
    {
        public static Utf8 Utf8 => default;
    }

    [ApiHost(ApiNames.TextEncoders, true)]
    public readonly partial struct TextEncoders
    {
        [MethodImpl(Inline), Op]
        public static TextEncodingService service(Encoding src)
            => new TextEncodingService(src);

        [MethodImpl(Inline), Op]
        public static ByteSize encode(Utf8 kind, ReadOnlySpan<char> src, Span<byte> dst)
            => kind.Encode(src,dst);

        [MethodImpl(Inline), Op]
        public static ref byte[] encode(Utf8 kind, string src, out byte[] dst)
            => ref kind.Encode(src,out dst);

        [MethodImpl(Inline), Op]
        public static void decode(Utf8 kind, ReadOnlySpan<byte> src, Span<char> dst)
            => kind.Decode(src,dst);

        [MethodImpl(Inline), Op]
        public static ref string decode(Utf8 kind, ReadOnlySpan<byte> src, out string dst)
            => ref kind.Decode(src, out dst);

        [MethodImpl(Inline), Op]
        public static ByteSize size(Utf8 kind, ReadOnlySpan<char> src)
            => kind.EncodedSize(src);

        [MethodImpl(Inline), Op]
        public static Utf8 utf8()
            => default;
    }
}