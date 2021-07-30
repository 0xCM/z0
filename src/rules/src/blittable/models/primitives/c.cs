//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    /// <summary>
    /// Represents the empty character
    /// </summary>
    public struct c0<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 1
    /// </summary>
    public struct c1<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 1;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 2
    /// </summary>
    public struct c2<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 2;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 3
    /// </summary>
    public struct c3<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 3;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 4
    /// </summary>
    public struct c4<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 4;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 5
    /// </summary>
    public struct c5<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 5;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 6
    /// </summary>
    public struct c6<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 6;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 7
    /// </summary>
    public struct c7<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 7;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 8
    /// </summary>
    public struct c8<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 8;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 16
    /// </summary>
    public struct c16<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 16;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a character of width 32
    /// </summary>
    public struct c32<T> : IChar<T>
        where T : unmanaged
    {
        public const ulong Width = 32;

        public T Storage;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }
}