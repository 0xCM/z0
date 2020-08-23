//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableGrid<F,T> : ITableContent<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public TableGrid(T[] data)
            => Data = data;

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}