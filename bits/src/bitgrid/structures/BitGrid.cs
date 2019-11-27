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
    public readonly ref struct BitGrid<T>
        where T : unmanaged
    {                
        readonly Block256<T> data;

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly ushort RowCount;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly ushort ColCount;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitGrid<T> g1, in BitGrid<T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitGrid<T> g1, in BitGrid<T> g2)
            => !g1.Equals(g2);
        
        [MethodImpl(Inline)]
        internal BitGrid(Block256<T> data, ushort rows, ushort width)
        {
            this.data = data;
            this.RowCount = rows;
            this.ColCount = width;
        }

        public Block256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }
        
        /// <summary>
        /// The number of cells over which the grid is defined
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => data.CellCount;
        }

        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => data.BlockCount;
        }

        public int BlockWidth
        {
            [MethodImpl(Inline)]
            get => data.BlockWidth;
        }

        public readonly GridMoniker<T> Moniker
            => GridMoniker.FromDim<T>(RowCount, ColCount);

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(ColCount, in Head, row, col);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(ColCount, row, col, value, ref Head);
        }

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(in Head, pos);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(pos, value, ref Head);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<T> rhs)
            => data.Identical(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}