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
        public static TextEncoders.Utf8 Utf8 => default;

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
        public static Utf8 utf8()
            => default;

        public readonly struct Utf8
        {
            static TextEncodingService Service => service(Encoding.UTF8);

            [MethodImpl(Inline)]
            internal ref byte[] Encode(string src, out byte[] dst)
            {
                dst = Service.GetBytes(src);
                return ref dst;
            }

            [MethodImpl(Inline)]
            internal ByteSize Encode(ReadOnlySpan<char> src, Span<byte> dst)
                => Service.GetBytes(src,dst);

            [MethodImpl(Inline)]
            internal void Decode(ReadOnlySpan<byte> src, Span<char> dst)
                => Service.GetChars(src,dst);

            [MethodImpl(Inline)]
            internal ref string Decode(ReadOnlySpan<byte> src, out string dst)
            {
                dst = Service.GetString(src);
                return ref dst;
            }
        }
    }
}