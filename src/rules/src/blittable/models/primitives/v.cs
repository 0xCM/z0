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

    public struct v0<T> : IPrimitive<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        BitWidth IPrimitive.ContentWidth
            => Width;

       TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    /// <summary>
    /// Defines a finite sequence of 1-bit values
    /// </summary>
    public struct v1<T> : IPrimitive<T>
        where T : unmanaged
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        internal v1(T[] cells)
        {
            Data = cells;
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        public uint Dim
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index)
            => ref Data[index];

        BitWidth IPrimitive.StorageWidth
            => Data.Length*size<T>();

        BitWidth IPrimitive.ContentWidth
            => Data.Length;

        TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }

    public struct vector<T>
        where T : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        internal vector(T[] data)
        {
            Data = data;
        }

    }
}
