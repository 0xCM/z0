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

        GridMoniker<T> moniker;


        [MethodImpl(Inline)]
        public static bool operator ==(BitGrid<T> lhs, BitGrid<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitGrid<T> lhs, BitGrid<T> rhs)
            => !lhs.Equals(rhs);
        

        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data, ushort m, ushort n)
        {
            this.data = data;
            this.moniker = GridMoniker.Define<T>(m,n);
        }

        [MethodImpl(Inline)]
        internal BitGrid(Span<T> data, GridMoniker<T> moniker)
        {
            this.data = data;
            this.moniker = moniker;
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
        
        public int SegCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public readonly GridMoniker<T> Moniker
        {
            [MethodImpl(Inline)]
            get => moniker;
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
        public bit GetState(int row, int col)
            => BitGrid.readbit(moniker, in Head, row, col);

        [MethodImpl(Inline)]
        public bit GetState(int bitpos)
            => BitGrid.readbit(in Head, bitpos);

        [MethodImpl(Inline)]
        public void SetState(int row, int col, bit state)
            => BitGrid.setbit(moniker, row, col, state, ref Head);

        [MethodImpl(Inline)]
        public void SetState(int bitpos, bit state)
            => BitGrid.setbit(bitpos, state, ref Head);

        [MethodImpl(Inline)]
        readonly int RowIndex(int row)        
            => (Moniker.ColCount * row) / Moniker.SegWidth;

        [MethodImpl(Inline)]
        readonly int RowOffset(int row)        
            => (Moniker.ColCount * row) % Moniker.SegWidth;

        [MethodImpl(Inline)]
        ref T RowSeg(int row)                
            => ref data[RowIndex(row)];

        
        // [MethodImpl(Inline)]
        // Span<T> RowData(int row)
        //     => data.Slice(RowOffset(row), Layout.RowCellCount);

        public BitString ToBitString()
            => data.ToBitString(Moniker.PointCount);

        public string Format()
            => ToBitString().Format(blockWidth:1,rowWidth:Moniker.ColCount);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<T> rhs)
            => data.Identical(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}