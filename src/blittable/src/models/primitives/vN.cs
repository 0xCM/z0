//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        /// <summary>
        /// Represents a finite sequence of 1-bit values covered byte <typeparamref='T'/> storage cells
        /// </summary>
        /// <typeparam name="T">The storage cell type</param>
        public struct vNx1<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vNx1(T[] cells)
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
        public struct vNx8<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vNx8(T[] cells)
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
        public struct vNx16<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vNx16(T[] cells)
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
        public struct vNx32<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vNx32(T[] cells)
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
        public struct vNx64<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vNx64(T[] cells)
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
        public struct vNx128<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vNx128(T[] cells)
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
        public struct vNx256<T> : IVector<T>
            where T : unmanaged
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vNx256(T[] cells)
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