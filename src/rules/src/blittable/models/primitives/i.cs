//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct i0<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i1<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 1;

        public T Storage;

        [MethodImpl(Inline)]
        public i1(T src)
        {
            Storage = src;
        }

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i2<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 2;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i3<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 3;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i4<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 4;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i5<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 5;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i6<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 6;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i7<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 7;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i8<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 8;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i16<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 16;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i32<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 32;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i64<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 64;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i128<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 128;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i256<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 256;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct i512<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 512;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }
}