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

    [ApiHost]
    public readonly struct BitFormatter : IBitFormatter
    {
        public static BitFormatter Service => default;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitFormatter<T> create<T>()
            where T : struct
                => default;

        [MethodImpl(Inline)]
        public static BitFormatConfig configure(bool tlz = false)
            => RenderOptions.bits(tlz);

        [MethodImpl(Inline)]
        public static BitFormatConfig limited(int maxbits, int? zpad = null)
            => RenderOptions.bitmax(maxbits, zpad);

        [MethodImpl(Inline)]
        public static BitFormatConfig blocked(int width, char? sep = null, int? maxbits = null, bool specifier = false)
            => RenderOptions.bitblock(width, sep, maxbits, specifier);

        
        [MethodImpl(Inline), Op]
        public void Format(byte src, int maxbits, Span<char> dst, ref int k)
            => api.bits(src, maxbits, dst, ref k);

        [MethodImpl(Inline), Op]
        public void Format(in byte src, int length, int maxbits, Span<char> dst)
            => api.bits(src,length,maxbits,dst);
        
        [MethodImpl(Inline), Op]
        public static void format(in byte src, int length, int maxbits, Span<char> dst)
            => api.bits(src, length, maxbits, dst);

        [MethodImpl(Inline)]
        public void Format(ReadOnlySpan<byte> src, int maxbits, Span<char> dst)
            => Format(first(src), src.Length, maxbits, dst);

        [MethodImpl(Inline)]
        public static void format(byte src, int maxbits, Span<char> dst, ref int k)
            => api.bits(src, maxbits, dst, ref k);

        [MethodImpl(Inline)]
        public static string format<T>(T src, in BitFormatConfig config)
            where T : struct
                => format(z.bytes(src), config);

        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct
                => format(src, BitFormatter.configure());

        [MethodImpl(Inline)]
        public static string format(ReadOnlySpan<byte> src, in BitFormatConfig config)
            => api.bits(src,config);
    }    
}