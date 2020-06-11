//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Control;

    [ApiHost]
    public readonly partial struct ByteBlocks : IApiHost<ByteBlocks>
    {
        [MethodImpl(Inline), Op]
        static Span<byte> u8span<T>(in T src)
            where T : struct
                => span8u(ref edit(src));

        [MethodImpl(Inline), Op]
        static ref byte u8ref<T>(in T src)
            => ref cast<T,byte>(src);

        [MethodImpl(Inline), Op]
        static ref byte u8<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,byte>(src), offset);

        [MethodImpl(Inline), Op]
        static ref byte u8ref<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,byte>(src), offset);

        public readonly struct ByteBlock1
        {
            public readonly byte Data;
        }

        public readonly struct ByteBlock2
        {
            public readonly ByteBlock1 Lo;

            public readonly ByteBlock1 Hi;
        }

        public readonly struct ByteBlock3
        {
            public readonly ByteBlock2 A;

            public readonly ByteBlock1 B;
        }

        public readonly struct ByteBlock4
        {
            public readonly ByteBlock2 Lo;

            public readonly ByteBlock2 Hi;
        }

        public readonly struct ByteBlock5
        {
            public readonly ByteBlock4 A;

            public readonly ByteBlock1 B;
        }

        public readonly struct ByteBlock6
        {
            public readonly ByteBlock5 A;

            public readonly ByteBlock1 B;
        }

        public readonly struct ByteBlock7
        {
            public readonly ByteBlock6 A;

            public readonly ByteBlock1 B;
        }

        public readonly struct ByteBlock8
        {
            public readonly ByteBlock4 Lo;

            public readonly ByteBlock4 Hi;
        }

        public readonly struct ByteBlock9
        {
            public readonly ByteBlock8 A;

            public readonly ByteBlock1 B;
        }

        public readonly struct ByteBlock10
        {
            public readonly ByteBlock8 A;

            public readonly ByteBlock2 B;
        }

        public readonly struct ByteBlock11
        {
            public readonly ByteBlock10 A;

            public readonly ByteBlock1 B;
        }

        public readonly struct ByteBlock12
        {
            public readonly ByteBlock8 A;

            public readonly ByteBlock4 B;
        }

        public readonly struct ByteBlock13
        {
            public readonly ByteBlock12 A;

            public readonly ByteBlock1 B;
        }

        public readonly struct ByteBlock14
        {
            public readonly ByteBlock7 Lo;

            public readonly ByteBlock7 Hi;
        }

        public readonly struct ByteBlock15
        {
            public readonly ByteBlock10 A;

            public readonly ByteBlock5 B;
        }

        public readonly struct ByteBlock16
        {
            public readonly ByteBlock8 Lo;

            public readonly ByteBlock8 Hi;
        }

        public readonly struct ByteBlock32
        {
            public readonly ByteBlock16 Lo;

            public readonly ByteBlock16 Hi;
        }

        public readonly struct ByteBlock64
        {
            public readonly ByteBlock32 Lo;

            public readonly ByteBlock32 Hi;
        }

        public readonly struct ByteBlock128
        {
            public readonly ByteBlock64 Lo;

            public readonly ByteBlock64 Hi;
        }
    }
}