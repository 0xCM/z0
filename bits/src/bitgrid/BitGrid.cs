//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines a grid of bits over a contiguous sequence of primal values
    /// </summary>
    public ref struct BitGrid<T>
        where T : unmanaged
    {        
        
        Span<T> data;

        GridMap map;
                
        readonly int M;

        readonly int N;


        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data, GridMap map)
        {
            this.data = data;
            this.map = map;
            this.M = map.RowCount;
            this.N = map.ColCount;
        }

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        public GridMap BitMap
        {
            [MethodImpl(Inline)]
            get => map;
        }
        
        public int SegCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.bitread(in Head, M, N, row, col);

            [MethodImpl(Inline)]
            set => BitGrid.bitset(ref Head, M, N, row, col, value);
        }

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => GetState(pos);

            [MethodImpl(Inline)]
            set => SetState(pos, value);
        }


        [MethodImpl(Inline)]
        public ref readonly CellMap CellMap(int row, int col)
            => ref map.Cell(row,col);

        [MethodImpl(Inline)]
        public ref readonly CellMap CellMap(int pos)
            => ref map.Cell(pos);
            
        [MethodImpl(Inline)]
        public bit GetState(int row, int col)
            => GetState(in CellMap(row,col));

        [MethodImpl(Inline)]
        public void SetState(int row, int col, bit state)
            => SetState(in CellMap(row,col), state);

        [MethodImpl(Inline)]
        public bit GetState(int pos)
            => GetState(CellMap(pos));

        [MethodImpl(Inline)]
        public void SetState(int pos, bit state)
            => SetState(CellMap(pos), state);

        [MethodImpl(Inline)]
        ref T Segment(int index)
            => ref seek(ref head(data), index);

        [MethodImpl(Inline)]
        bit GetState(in CellMap cell)
            => gbits.test(Segment(cell.Segment), cell.Offset);

        [MethodImpl(Inline)]
        void SetState(in CellMap cell, bit state)
            => gbits.set(ref Segment(cell.Segment), (byte)cell.Offset, state);

        public string Format()
            => data.FormatMatrixBits((int)map.ColCount);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<T> rhs)
            => data.Identical(rhs.data);
    }
}