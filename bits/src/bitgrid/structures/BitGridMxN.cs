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
    /// Defines a maximally packed data structure of natural dimensions over a primal type
    /// </summary>
    public readonly ref struct BitGrid<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {                
        readonly Block256<T> data;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static Dim<M,N> Dim => default;

        [MethodImpl(Inline)]
        public static bit operator ==(in BitGrid<M,N,T> g1, in BitGrid<M,N,T> g2)
            => BitGrid.same(g1,g2);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitGrid<M,N,T> g1, in BitGrid<M,N,T> g2)
            => !BitGrid.same(g1,g2);

        [MethodImpl(Inline)]
        internal BitGrid(Block256<T> data)
        {
            this.data = data;
        }

        /// <summary>
        /// The allocated storage
        /// </summary>
        public Block256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// A reference to the leading storage cell
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data.Head;
        }

        /// <summary>
        /// The natural width of the grid, equivalent in numeric value to the column count
        /// </summary>
        public N GridWidth => default;

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => natval<M>();
        }

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount
        {
            [MethodImpl(Inline)]
            get => natval<N>();
        }

        /// <summary>
        /// The number of cells over which the grid is defined
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.cellcount<T>(RowCount, ColCount);
        }

        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => NatMath.mul<M,N>(); 
        }

        /// <summary>
        /// The number of allocated 256-bit blocks 
        /// </summary>
        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => data.BlockCount;
        }
         
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(GridWidth, in Head, row, col);

            [MethodImpl(Inline)]
            set => BitGrid.setbit(GridWidth, row, col, value, ref Head);
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
            get => BitGrid.read(this, block);

            [MethodImpl(Inline)]
            set => BitGrid.write(value, this, block);
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
        public Block256<T> Block(int block)
            => data.Block(block);

        public GridMoniker<T> Moniker
            => GridMoniker.FromTypes<M,N,T>();
            
        [MethodImpl(Inline)]
        public bool Equals(BitGrid<M,N,T> rhs)
            => Data.Identical(rhs.data);
 
        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}