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

    public class Grid<T>
    {
        readonly Index<T> Data;

        public GridDim Dim {get;}

        public Grid(GridDim dim)
        {
            Dim = dim;
            Data = sys.alloc<T>(Dim.RowCount*Dim.ColCount);
        }

        [MethodImpl(Inline)]
        internal Grid(GridDim dim, T[] storage)
        {
            Dim = dim;
            Data = storage;
        }

        ref T First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint row, uint col)
            => ref seek(First, GridCalcs.linear(Dim, row, col));

        [MethodImpl(Inline)]
        public ref T Cell(GridCell point)
            => ref seek(First, GridCalcs.linear(Dim, point));

        public ref T this[uint row, uint col]
        {
            [MethodImpl(Inline)]
            get => ref Cell(row,col);
        }
    }
}