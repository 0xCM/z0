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

    public class Grid<T>
    {
        readonly Index<T> Data;

        public GridDim Dim {get;}

        public Grid(GridDim dim)
        {
            Dim = dim;
            Data = alloc<T>(Dim.M*Dim.N);
        }

        [MethodImpl(Inline)]
        public Grid(GridDim dim, T[] data)
        {
            Dim = dim;
            Data = data;
        }

        ref T First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint row, uint col)
            => ref seek(First, linear(Dim, (row, col)));

        [MethodImpl(Inline)]
        public ref T Cell(GridPoint point)
            => ref seek(First, linear(Dim, point));

        public ref T this[uint row, uint col]
        {
            [MethodImpl(Inline)]
            get => ref Cell(row,col);
        }

        [MethodImpl(Inline)]
        static uint linear(GridDim dim, GridPoint point)
            => point.Row*dim.N+ point.Col;
    }
}