//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Render;

    [ApiHost("formatting.bits")]
    public readonly struct BitFormatter : IBitFormatter
    {
        public static BitFormatter Service => default;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitFormatter<T> create<T>()
            where T : struct
                => default;

        [MethodImpl(Inline)]
        public static BitFormat configure(bool tlz = false)
            => FormatOptions.bits(tlz);

        [MethodImpl(Inline)]
        public static BitFormat limited(uint maxbits, int? zpad = null)
            => FormatOptions.bitmax(maxbits, zpad);

        [MethodImpl(Inline)]
        public static BitFormat blocked(int width, char? sep = null, uint? maxbits = null, bool specifier = false)
            => FormatOptions.bitblock(width, sep, maxbits, specifier);

        [MethodImpl(Inline), Op]
        public void Format(byte src, uint maxbits, Span<char> dst, ref int k)
            => api.bits(src, maxbits, dst, ref k);

        [MethodImpl(Inline), Op]
        public void Format(in byte src, int length, uint maxbits, Span<char> dst)
            => api.bits(src,length,maxbits,dst);

        [MethodImpl(Inline), Op]
        public static void format(in byte src, int length, uint maxbits, Span<char> dst)
            => api.bits(src, length, maxbits, dst);

        [MethodImpl(Inline)]
        public void Format(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
            => Format(first(src), src.Length, maxbits, dst);

        [MethodImpl(Inline)]
        public static void format(byte src, uint maxbits, Span<char> dst, ref int k)
            => api.bits(src, maxbits, dst, ref k);

        [MethodImpl(Inline)]
        public static string format<T>(T src, in BitFormat config)
            where T : struct
                => format(z.bytes(src), config);

        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct
                => format(src, BitFormatter.configure());

        [MethodImpl(Inline)]
        public static string format(ReadOnlySpan<byte> src, in BitFormat config)
            => api.bits(src,config);
    }
}