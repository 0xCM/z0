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


    [ApiHost]
    public readonly partial struct ByteBlocks : IApiHost<ByteBlocks>
    {
        [MethodImpl(Inline)]
        static Span<byte> u8span<T>(in T src)
            where T : struct
                => span8u(ref edit(src));

        [MethodImpl(Inline)]
        static ref byte u8ref<T>(in T src)
            => ref cast<T,byte>(src);

        [MethodImpl(Inline)]
        static ref byte u8<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,byte>(src), offset);

        [MethodImpl(Inline)]
        static ref byte u8ref<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,byte>(src), offset);

        /// <summary>
        /// 1 byte of storage
        /// </summary>
        public readonly struct ByteBlock1
        {
            public readonly byte Data;
        }

        /// <summary>
        /// 2 bytes of storage
        /// </summary>
        public readonly struct ByteBlock2
        {
            public readonly ByteBlock1 Lo;

            public readonly ByteBlock1 Hi;
        }

        /// <summary>
        /// 3 bytes of storage
        /// </summary>
        public readonly struct ByteBlock3
        {
            public readonly ByteBlock2 A;

            public readonly ByteBlock1 B;
        }

        /// <summary>
        /// 4 bytes of storage
        /// </summary>
        public readonly struct ByteBlock4
        {
            public readonly ByteBlock2 Lo;

            public readonly ByteBlock2 Hi;
        }

        /// <summary>
        /// 5 bytes of storage
        /// </summary>
        public readonly struct ByteBlock5
        {
            public readonly ByteBlock4 A;

            public readonly ByteBlock1 B;
        }

        /// <summary>
        /// 6 bytes of storage
        /// </summary>
        public readonly struct ByteBlock6
        {
            public readonly ByteBlock5 A;

            public readonly ByteBlock1 B;
        }

        /// <summary>
        /// 7 bytes of storage
        /// </summary>
        public readonly struct ByteBlock7
        {
            public readonly ByteBlock6 A;

            public readonly ByteBlock1 B;
        }

        /// <summary>
        /// 8 bytes of storage
        /// </summary>
        public readonly struct ByteBlock8
        {
            public readonly ByteBlock4 Lo;

            public readonly ByteBlock4 Hi;
        }

        /// <summary>
        /// 9 bytes of storage
        /// </summary>
        public readonly struct ByteBlock9
        {
            public readonly ByteBlock8 A;

            public readonly ByteBlock1 B;
        }

        /// <summary>
        /// 10 bytes of storage
        /// </summary>
        public readonly struct ByteBlock10
        {
            public readonly ByteBlock8 A;

            public readonly ByteBlock2 B;
        }

        /// <summary>
        /// 11 bytes of storage
        /// </summary>
        public readonly struct ByteBlock11
        {
            public readonly ByteBlock10 A;

            public readonly ByteBlock1 B;
        }

        /// <summary>
        /// 12 bytes of storage
        /// </summary>
        public readonly struct ByteBlock12
        {
            public readonly ByteBlock8 A;

            public readonly ByteBlock4 B;
        }

        /// <summary>
        /// 13 bytes of storage
        /// </summary>
        public readonly struct ByteBlock13
        {
            public readonly ByteBlock12 A;

            public readonly ByteBlock1 B;
        }

        /// <summary>
        /// 14 bytes of storage
        /// </summary>
        public readonly struct ByteBlock14
        {
            public readonly ByteBlock7 Lo;

            public readonly ByteBlock7 Hi;
        }

        /// <summary>
        /// 15 bytes of storage
        /// </summary>
        public readonly struct ByteBlock15
        {
            public readonly ByteBlock10 A;

            public readonly ByteBlock5 B;
        }

        /// <summary>
        /// 16 bytes of storage
        /// </summary>
        public readonly struct ByteBlock16
        {
            public readonly ByteBlock8 Lo;

            public readonly ByteBlock8 Hi;
        }

        /// <summary>
        /// 32 bytes of storage
        /// </summary>
        public readonly struct ByteBlock32
        {
            public readonly ByteBlock16 Lo;

            public readonly ByteBlock16 Hi;
        }

        /// <summary>
        /// 64 bytes of storage
        /// </summary>
        public readonly struct ByteBlock64
        {
            public readonly ByteBlock32 Lo;

            public readonly ByteBlock32 Hi;
        }

        /// <summary>
        /// 127 bytes of storage
        /// </summary>
        public readonly struct ByteBlock128
        {
            public readonly ByteBlock64 Lo;

            public readonly ByteBlock64 Hi;
        }
    }
}