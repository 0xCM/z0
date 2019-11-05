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
    /// Defines a bitgrid of natural dimensions over a primal type
    /// </summary>
    public ref struct BitGrid<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        

        static GridMap Map => BitGridInfo<M,N,T>.Map;
        
        Span<T> data;
            
        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data)
        {
            this.data = data;
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
            get => Map;
        }
        
        public int SegCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetState(row,col);

            [MethodImpl(Inline)]
            set => SetState(row,col,value);
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
            => ref Map.Cell(row,col);

        [MethodImpl(Inline)]
        public ref readonly CellMap CellMap(int pos)
            => ref Map.Cell(pos);
            
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
            => data.FormatMatrixBits((int)Map.ColCount);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<M,N,T> rhs)
            => data.Identical(rhs.data);
    }
}