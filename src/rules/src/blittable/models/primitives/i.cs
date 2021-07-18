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

    public struct i0<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i1<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 1;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i2<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 2;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i3<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 3;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i4<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 4;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i5<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 5;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i6<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 6;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i7<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 7;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i8<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 8;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;

    }

    public struct i16<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 16;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i32<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 32;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i64<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 64;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i128<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 128;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i256<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 256;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    public struct i512<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 512;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }
}