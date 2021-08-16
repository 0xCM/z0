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

    partial struct Blit
    {
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

            public Span<T> Cells
                => default;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }

        /// <summary>
        /// Represents a finite sequence of 1-bit values covered byte <typeparamref='T'/> storage cells
        /// </summary>
        /// <typeparam name="T">The storage cell type</param>
        public struct v1<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal v1(T[] cells)
            {
                Data = cells;
            }

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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
        /// Represents a finite sequence of 8-bit values
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

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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
                => Cells.Length*width<T>();

            BitWidth IPrimitive.ContentWidth
                => Cells.Length*128;
        }

        /// <summary>
        /// Represents a finite sequence of 128-bit values
        /// </summary>
        public struct v256<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal v256(T[] cells)
            {
                Data = cells;
            }

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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
                => Cells.Length*width<T>();

            BitWidth IPrimitive.ContentWidth
                => Cells.Length*256;
        }

        public struct vector<N,T> : IVector<T>
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vector(T[] src)
            {
                Data = src;
            }

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }

            [MethodImpl(Inline)]
            public ref T Cell(uint index)
                => ref Data[index];

            public ref T this[uint index]
            {
                [MethodImpl(Inline)]
                get => ref Cell(index);
            }

            public string Format()
                => Operate.format(this);

            public override string ToString()
                => Format();

            BitWidth IPrimitive.StorageWidth
                => Data.Length*width<T>();

            BitWidth IPrimitive.ContentWidth
                => Data.Length* Typed.nat32u<N>();

            uint IVector.N
                => Typed.nat32u<N>();

            public static vector<N,T> Empty => default;
        }
    }
}