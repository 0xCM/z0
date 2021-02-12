//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines an indexed sequence of <typeparamref name='T'/> cells
    /// </summary>
    [Datatype("m(n)")]
    public readonly struct Cells<T> : ITableSpan<Cells<T>,T>
        where T : struct, IDataCell<T>
    {
        readonly IndexedSeq<T> Data;

        [MethodImpl(Inline)]
        public Cells(T[] src)
            => Data = src;

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get =>  Data.Storage;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get =>  Data.View;
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Cells<T> Refresh(T[] src)
            => src;

        public static uint CellWidth
            => width<T>();

        [MethodImpl(Inline)]
        public static implicit operator Cells<T>(T[] src)
            => new Cells<T>(src);
    }
}