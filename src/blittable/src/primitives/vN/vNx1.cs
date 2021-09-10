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

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static vNx1<bit> v(N1 n, bit[] src)
            => new vNx1<bit>(src);

        [MethodImpl(Inline), Op]
        public static vNx1<byte> v(N1 n, byte[] src)
            => new vNx1<byte>(src);

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
    }
}