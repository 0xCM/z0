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

    partial struct BitFlow
    {
        public static string format(in bitspan src)
        {
            var count = (int)src.Width;
            Span<char> buffer = stackalloc char[count];
            for(var i=0; i<count; i++)
                seek(buffer,i) = src[i].ToChar();
            buffer.Reverse();
            return text.format(buffer);
        }

        public readonly ref struct bitspan
        {
            public static bitspan create(uint width, byte src, Span<bit> buffer)
            {
                var input = src;
                var storage = 0ul;
                ref var _dst = ref @as<ulong,bit>(storage);
                Span<bit> dst = alloc<bit>(width);
                for(byte i=0; i<width; i++)
                    seek(buffer,i) = bit.test(input,i);
                return new bitspan(slice(buffer,0,width));
            }

            readonly Span<bit> Bits;

            [MethodImpl(Inline)]
            public bitspan(Span<bit> b)
            {
                Bits = b;
            }

            public uint Width
            {
                [MethodImpl(Inline)]
                get => (uint)Bits.Length;
            }

            public ref bit this[long i]
            {
                [MethodImpl(Inline)]
                get => ref seek(Bits,i);
            }

            public ref bit this[ulong i]
            {
                [MethodImpl(Inline)]
                get => ref seek(Bits,i);
            }

            public string Format()
                => format(this);
        }
    }
}