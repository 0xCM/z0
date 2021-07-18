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

    public struct u0<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;

    }

    public struct u1<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 1;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u2<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 2;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u3<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 3;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u4<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 4;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u5<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 5;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u6<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 6;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u7<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 7;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u8<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 8;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u16<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 16;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u32<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 32;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u64<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 64;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u128<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 128;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u256<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 256;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct u512<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 512;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

}