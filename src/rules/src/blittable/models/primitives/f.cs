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

    public struct f0<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;

        TypeKind IPrimitive.TypeKind
            => TypeKind.Float;
    }

    public struct f16<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 16;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

        TypeKind IPrimitive.TypeKind
            => TypeKind.Float;
    }

    public struct f32<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 32;
        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

        TypeKind IPrimitive.TypeKind
            => TypeKind.Float;
    }

    public struct f64<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 64;
        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

        TypeKind IPrimitive.TypeKind
            => TypeKind.Float;
    }
}