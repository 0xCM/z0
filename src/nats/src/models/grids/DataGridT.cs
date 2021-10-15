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

    /// <summary>
    /// Defines a grid over cells of unmanaged type
    /// </summary>
    public readonly struct DataGrid<T>
        where T : unmanaged
    {
        public GridDim Dim {get;}

        readonly Index<T> Data;

        [MethodImpl(Inline)]
        public DataGrid(GridDim dim, T[] src)
        {
            Dim = dim;
            Data = src;
        }

        public ref T this[uint row, uint col]
        {
            [MethodImpl(Inline)]
            get => ref Data[Dim.Offset(row,col)];
        }

        public ref T this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => ref Data[Dim.Offset((uint)row,(uint)col)];
        }

        [MethodImpl(Inline)]
        public Span<T> Row(uint row)
            => cover(Data[row*Dim.N], Dim.N);

        public Span<T> this[uint row]
        {
            [MethodImpl(Inline)]
            get => Row(row);
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint RowCount
        {
            [MethodImpl(Inline)]
            get => Dim.M;
        }

        public uint ColCount
        {
            [MethodImpl(Inline)]
            get => Dim.N;
        }

    }
}