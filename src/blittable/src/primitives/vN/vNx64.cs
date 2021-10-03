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
        public static vNx64<ulong> v(N64 n, ulong[] src)
            => new vNx64<ulong>(src);

        [MethodImpl(Inline), Op]
        public static vNx64<MemoryAddress> v(N64 n, MemoryAddress[] src)
            => new vNx64<MemoryAddress>(src);

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

            BitWidth IBlittable.StorageWidth
                => Data.Length*width<T>();

            BitWidth IBlittable.ContentWidth
                => Data.Length*64;
        }
    }
}