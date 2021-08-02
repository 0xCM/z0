//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    public struct f0<T> : IFloat<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct f16<T> : IFloat<T>
        where T : unmanaged
    {
        public const ulong Width = 16;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    public struct f32<T> : IFloat<T>
        where T : unmanaged
    {
        public const ulong Width = 32;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;

    }

    public struct f64<T> : IFloat<T>
        where T : unmanaged
    {
        public const ulong Width = 64;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }
}