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

    public readonly struct Utf8
    {
        static TextEncodingService Service => TextEncoders.service(Encoding.UTF8);

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
        internal ByteSize EncodedSize(ReadOnlySpan<char> src)
            => Service.GetByteCount(src);

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