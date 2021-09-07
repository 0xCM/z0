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
        [MethodImpl(Inline), Op]
        public static vNx32<uint> v(N32 n,  uint[] src)
            => new vNx32<uint>(src);

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
    }
}