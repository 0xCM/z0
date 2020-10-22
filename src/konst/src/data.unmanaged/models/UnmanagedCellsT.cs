//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct UnmanagedCells<T> : IUnmanagedCells<T>
        where T : unmanaged
    {
        public readonly T[] Data;

        [MethodImpl(Inline)]
        public UnmanagedCells(T[] src)
            => Data = src;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ByteSize CellSize
        {
            [MethodImpl(Inline)]
            get => z.size<T>();
        }

        T[] IUnmanagedCells<T>.Storage
            => Data;

        [MethodImpl(Inline)]
        public static implicit operator UnmanagedCells<T>(T[] src)
            => new UnmanagedCells<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](UnmanagedCells<T> src)
            => src.Data;
    }
}