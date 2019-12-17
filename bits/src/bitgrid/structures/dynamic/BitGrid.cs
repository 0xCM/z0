//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Defines a grid of bits over a contiguous sequence of primal values stored in blocks of 256 bits
    /// </summary>
    /// <typeparam name="T">The grid cell type</typeparam>
    public readonly ref struct BitGrid<T>
        where T : unmanaged
    {                
        internal readonly Block256<T> data;

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly int RowCount;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly int ColCount;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitGrid<T> g1, in BitGrid<T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitGrid<T> g1, in BitGrid<T> g2)
            => !g1.Equals(g2);
        
        [MethodImpl(Inline)]
        internal BitGrid(Block256<T> data, int rows, int cols)
        {
            this.data = data;
            this.RowCount = rows;
            this.ColCount = cols;
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
            get => BitCalcs.tablecells<T>(RowCount, ColCount);
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => data.BlockCount;
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(ColCount, in Head, row, col);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(ColCount, row, col, value, ref Head);
        }

        [MethodImpl(Inline)]
        public void SetBit(int index, bit state)
            => BitGrid.setbit(index, state, ref Head);

        [MethodImpl(Inline)]
        public bit ReadBit(int index)
            => BitGrid.readbit(in Head, index);

        /// <summary>
        /// Transfers 256-bit cpu vectors to/from blocked storage
        /// </summary>
        public Vector256<T> this[int block]
        {
            [MethodImpl(Inline)]
            get => BitGrid.vector(this, block);

            [MethodImpl(Inline)]
            set => BitGrid.store(value, this, block);
        }

        /// <summary>
        /// Reads/writes an index-identified grid cell
        /// </summary>
        /// <param name="index">The 0-based linear cell index</param>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Returns the 256-bit block corresponding to a block index
        /// </summary>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public Span<T> Block(int block)
            => data.SpanBlock(block);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid<T> rhs)
            => data.Identical(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}