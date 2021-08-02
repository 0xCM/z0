//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct u0<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u1<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 1;

        public T Storage;

        [MethodImpl(Inline)]
        public u1(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u2<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 2;

        public T Storage;

        [MethodImpl(Inline)]
        public u2(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u3<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 3;

        public T Storage;

        [MethodImpl(Inline)]
        public u3(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u4<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 4;

        public T Storage;

        [MethodImpl(Inline)]
        public u4(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u5<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 5;

        public T Storage;

        [MethodImpl(Inline)]
        public u5(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u6<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 6;

        public T Storage;

        [MethodImpl(Inline)]
        public u6(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u7<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 7;

        public T Storage;

        [MethodImpl(Inline)]
        public u7(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u8<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 8;

        public T Storage;

        [MethodImpl(Inline)]
        public u8(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u8 : IUnsigned<byte>
    {
        public const ulong Width = 8;

        public byte Storage;

        [MethodImpl(Inline)]
        public u8(byte src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;

        [MethodImpl(Inline)]
        public static implicit operator u8(u8<byte> src)
            => new u8(src.Storage);

        [MethodImpl(Inline)]
        public static implicit operator u8<byte>(u8 src)
            => new u8<byte>(src.Storage);

        [MethodImpl(Inline)]
        public static implicit operator u8(byte src)
            => new u8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(u8 src)
            => src.Storage;

    }

    public struct u16<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 16;

        public T Storage;

        [MethodImpl(Inline)]
        public u16(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u32<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 32;

        public T Storage;

        [MethodImpl(Inline)]
        public u32(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u64<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 64;

        public T Storage;

        [MethodImpl(Inline)]
        public u64(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u128<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 128;

        public T Storage;

        [MethodImpl(Inline)]
        public u128(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u256<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 256;

        public T Storage;

        [MethodImpl(Inline)]
        public u256(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct u512<T> : IUnsigned<T>
        where T : unmanaged
    {
        public const ulong Width = 512;

        public T Storage;

        [MethodImpl(Inline)]
        public u512(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }
}