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

    using api = Blit.Operate;

    partial struct Blit
    {
        public struct bv<T>
            where T : unmanaged
        {
            public uint Width;

            public T Storage;

            [MethodImpl(Inline)]
            public bv(uint width, T bits)
            {
                Width = width;
                Storage = bits;
            }
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
                => api.format(this);
        }

        public struct bv0 : IScalarBits<byte>
        {
            public const uint Width = 0;

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => 0;

                [MethodImpl(Inline)]
                set{}
            }
        }

        public struct bv1 : IScalarBits<byte>
        {
            public const uint Width = 1;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv1(byte src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv1 src)
                => new bv<byte>(Width, src.Storage);
        }

        public struct bv2 : IScalarBits<byte>
        {
            public const uint Width = 2;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv2(byte src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv2 src)
                => new bv<byte>(Width, src.Storage);

            [MethodImpl(Inline)]
            public static implicit operator bv2(bv<byte> src)
                => new bv2(src.Storage);
        }

        public struct bv3 : IScalarBits<byte>
        {
            public const uint Width = 3;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv3(byte src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv3 src)
                => new bv<byte>(Width, src.Storage);

            [MethodImpl(Inline)]
            public static implicit operator bv3(bv<byte> src)
                => new bv3(src.Storage);
        }

        public struct bv4 : IScalarBits<byte>
        {
            public const uint Width = 4;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv4(byte src)
            {
                Storage = src;
            }
            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv4 src)
                => new bv<byte>(Width, src.Storage);

        }

        public struct bv5 : IScalarBits<byte>
        {
            public const uint Width = 5;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv5(byte src)
            {
                Storage = src;
            }
            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv5 src)
                => new bv<byte>(Width, src.Storage);

        }

        public struct bv6 : IScalarBits<byte>
        {
            public const uint Width = 6;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv6(byte src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv6 src)
                => new bv<byte>(Width, src.Storage);

        }

        public struct bv7 : IScalarBits<byte>
        {
            public const uint Width = 7;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv7(byte src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv7 src)
                => new bv<byte>(Width, src.Storage);

        }

        public struct bv8 : IScalarBits<byte>
        {
            public const uint Width = 8;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv8(byte src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<byte>(bv8 src)
                => new bv<byte>(Width, src.Storage);

        }

        public struct bv16 : IScalarBits<ushort>
        {
            public const uint Width = 16;

            public ushort Storage;

            [MethodImpl(Inline)]
            public bv16(ushort src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<ushort>(bv16 src)
                => new bv<ushort>(Width, src.Storage);
        }

        public struct bv32 : IScalarBits<uint>
        {
            public const uint Width = 32;

            public uint Storage;

            [MethodImpl(Inline)]
            public bv32(uint src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<uint>(bv32 src)
                => new bv<uint>(Width, src.Storage);
        }

        public struct bv64 : IScalarBits<ulong>
        {
            public const uint Width = 64;

            public ulong Storage;

            [MethodImpl(Inline)]
            public bv64(ulong src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<ulong>(bv64 src)
                => new bv<ulong>(Width, src.Storage);
        }

        public struct bv128 : IScalarBits<ByteBlock16>
        {
            public const uint Width = 64;

            public ByteBlock16 Storage;

            [MethodImpl(Inline)]
            public bv128(ByteBlock16 src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => throw Unsupported.define<bv128>();

                [MethodImpl(Inline)]
                set => throw Unsupported.define<bv128>();
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<ByteBlock16>(bv128 src)
                => new bv<ByteBlock16>(Width, src.Storage);
        }

    }
}