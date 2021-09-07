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

    partial struct Blit
    {
        [Op]
        public static string format(in bv src)
        {
            var count = (int)src.Width;
            Span<char> buffer = stackalloc char[count];
            for(var i=0; i<count; i++)
                seek(buffer,i) = src[i].ToChar();
            buffer.Reverse();
            return text.format(buffer);
        }

        public readonly ref struct bv
        {
            readonly Span<bit> Bits;

            [MethodImpl(Inline)]
            public bv(Span<bit> b)
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