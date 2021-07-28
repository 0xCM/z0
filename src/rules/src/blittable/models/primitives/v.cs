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

    /// <summary>
    /// Represents the empty vector
    /// </summary>
    public struct v0<T> : IVector<T>
        where T : unmanaged
    {
        public const ulong Width = 0;

        public ref T this[uint i]
            => throw new Exception("I do not exist");

        public uint N => 0;

        BitWidth IPrimitive.ContentWidth
            => Width;
    }

    /// <summary>
    /// Represents a finite sequence of 1-bit values
    /// </summary>
    public struct v1<T> : IVector<T>
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

        public uint N
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index)
            => ref Data[index];

        BitWidth IPrimitive.StorageWidth
            => Data.Length*width<T>();

        BitWidth IPrimitive.ContentWidth
            => Data.Length*1;
    }

    /// <summary>
    /// Represents a finite sequence of 16-bit values
    /// </summary>
    public struct v8<T> : IVector<T>
        where T : unmanaged
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        internal v8(T[] cells)
        {
            Data = cells;
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        public uint N
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index)
            => ref Data[index];

        BitWidth IPrimitive.StorageWidth
            => Data.Length*width<T>();

        BitWidth IPrimitive.ContentWidth
            => Data.Length*8;
    }

    /// <summary>
    /// Represents a finite sequence of 16-bit values
    /// </summary>
    public struct v16<T> : IVector<T>
        where T : unmanaged
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        internal v16(T[] cells)
        {
            Data = cells;
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        public uint N
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index)
            => ref Data[index];

        BitWidth IPrimitive.StorageWidth
            => Data.Length*width<T>();

        BitWidth IPrimitive.ContentWidth
            => Data.Length*16;
    }

    /// <summary>
    /// Represents a finite sequence of 32-bit values
    /// </summary>
    public struct v32<T> : IVector<T>
        where T : unmanaged
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        internal v32(T[] cells)
        {
            Data = cells;
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        public uint N
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index)
            => ref Data[index];

        BitWidth IPrimitive.StorageWidth
            => Data.Length*width<T>();

        BitWidth IPrimitive.ContentWidth
            => Data.Length*32;
    }

    /// <summary>
    /// Represents a finite sequence of 64-bit values
    /// </summary>
    public struct v64<T> : IVector<T>
        where T : unmanaged
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        internal v64(T[] cells)
        {
            Data = cells;
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        public uint N
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index)
            => ref Data[index];

        BitWidth IPrimitive.StorageWidth
            => Data.Length*width<T>();

        BitWidth IPrimitive.ContentWidth
            => Data.Length*64;
    }

    /// <summary>
    /// Represents a finite sequence of 128-bit values
    /// </summary>
    public struct v128<T> : IVector<T>
        where T : unmanaged
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        internal v128(T[] cells)
        {
            Data = cells;
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        public uint N
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index)
            => ref Data[index];

        BitWidth IPrimitive.StorageWidth
            => Data.Length*width<T>();

        BitWidth IPrimitive.ContentWidth
            => Data.Length*128;
    }
}