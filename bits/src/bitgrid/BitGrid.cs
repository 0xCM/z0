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

    public unsafe ref struct BitGrid2
    {
        Span<byte> data;

        [MethodImpl(Inline)]
        internal BitGrid2(Span<byte> data)
        {
            this.data = data;
        }

        public ref byte Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        public int SegCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public unsafe byte* HeadPtr
        {
            [MethodImpl(Inline)]
            get => As.refptr(ref head(data));
        }

    }

    /// <summary>
    /// Defines a bitgrid of natural dimensions over a primal type
    /// </summary>
    public ref struct BitGrid<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        

        Span<T> data;

        GridMap bitmap;
                

        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data, GridMap layout)
        {
            this.data = data;
            this.bitmap = layout;
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
            get => bitmap;
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
            => ref bitmap.Cell(row,col);

        [MethodImpl(Inline)]
        public ref readonly CellMap CellMap(int pos)
            => ref bitmap.Cell(pos);
            
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
            => data.FormatMatrixBits((int)bitmap.ColCount);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<M,N,T> rhs)
            => data.Identical(rhs.data);
 
        public unsafe T* HeadPtr
        {
            [MethodImpl(Inline)]
            get => As.refptr(ref head(data));
        }

    }
}