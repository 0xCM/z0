//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct SpanBlocks
    {
        [MethodImpl(Inline), Op]
        public static SpanBlock8<byte> bytes(W8 w, Span<byte> src)
            => new SpanBlock8<byte>(src);

        [MethodImpl(Inline), Op]
        public static SpanBlock16<byte> bytes(W16 w, Span<byte> src)
        {
            const byte Size = 2;
            var div = src.Length / Size;
            if(div > 0)
                return new SpanBlock16<byte>(memory.cover(first(src), Size * div));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock32<byte> bytes(W32 w, Span<byte> src)
        {
            const byte Size = 4;
            var div = src.Length / Size;
            if(div > 0)
                return new SpanBlock32<byte>(memory.cover(first(src), Size * div));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock64<byte> bytes(W64 w, Span<byte> src)
        {
            const byte Size = 8;
            var div = src.Length / Size;
            if(div > 0)
                return new SpanBlock64<byte>(memory.cover(first(src), Size * div));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock128<byte> bytes(W128 w, Span<byte> src)
        {
            const byte Size = 16;
            var div = src.Length / Size;
            if(div > 0)
                return new SpanBlock128<byte>(memory.cover(first(src), Size * div));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock256<byte> bytes(W256 w, Span<byte> src)
        {
            const byte Size = 32;
            var div = src.Length / Size;
            if(div > 0)
                return new SpanBlock256<byte>(memory.cover(first(src), Size * div));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock16<byte> bytes(W16 w, Span<byte> src, out Span<byte> unused)
        {
            const byte Size = 2;
            var count = src.Length;
            var div = count / Size;
            var mod = count % Size;
            if(div > 0)
            {
                unused = mod != 0 ? slice(src, div, mod) : default;
                return new SpanBlock16<byte>(memory.cover(first(src), Size * div));
            }
            else
            {
                unused = src;
                return default;
            }
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock32<byte> bytes(W32 w, Span<byte> src, out Span<byte> unused)
        {
            const byte Size = 4;
            var count = src.Length;
            var div = count / Size;
            var mod = count % Size;
            if(div > 0)
            {
                unused = mod != 0 ? slice(src, div, mod) : default;
                return new SpanBlock32<byte>(memory.cover(first(src), Size * div));
            }
            else
            {
                unused = src;
                return default;
            }
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock64<byte> bytes(W64 w, Span<byte> src, out Span<byte> unused)
        {
            const byte Size = 8;
            var count = src.Length;
            var div = count / Size;
            var mod = count % Size;
            if(div > 0)
            {
                unused = mod != 0 ? slice(src, div, mod) : default;
                return new SpanBlock64<byte>(memory.cover(first(src), Size * div));
            }
            else
            {
                unused = src;
                return default;
            }
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock128<byte> bytes(W128 w, Span<byte> src, out Span<byte> unused)
        {
            const byte Size = 16;
            var count = src.Length;
            var div = count / Size;
            var mod = count % Size;
            if(div > 0)
            {
                unused = mod != 0 ? slice(src, div, mod) : default;
                return new SpanBlock128<byte>(memory.cover(first(src), Size * div));
            }
            else
            {
                unused = src;
                return default;
            }
        }

        [MethodImpl(Inline), Op]
        public static SpanBlock256<byte> bytes(W256 w, Span<byte> src, out Span<byte> unused)
        {
            const byte Size = 32;
            var count = src.Length;
            var div = count / Size;
            var mod = count % Size;
            if(div > 0)
            {
                unused = mod != 0 ? slice(src, div, mod) : default;
                return new SpanBlock256<byte>(memory.cover(first(src), Size * div));
            }
            else
            {
                unused = src;
                return default;
            }
        }
    }
}