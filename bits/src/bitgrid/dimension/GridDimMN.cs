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

    public readonly struct GridDim<M,N,T> : IGridDim<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {

        /// <summary>
        /// The total number gb of grid bits determined by gb := MxN
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.bitcount<M,N>();
        }

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
        /// The bit width of a storage cell
        /// </summary>
        public int CellWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }

        /// <summary>
        /// The bit width of a storage block
        /// </summary>
        public int BlockWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }

        /// <summary>
        /// The number of cells required cover a grid
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.cellcount<M,N,T>();
        }

        /// <summary>
        /// The number of bytes required to cover a grid
        /// </summary>
        public int ByteCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.bytecount<M,N>();
        }

        /// <summary>
        /// A semantic identifier that characterizes/identifies a grid
        /// </summary>
        public GridMoniker Moniker 
        {
            [MethodImpl(Inline)]
            get => GridMoniker.FromTypes<M,N,T>();
        }

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public int Pos(int row, int col)
            => BitCalcs.bitpos<N>(row, col);

        /// <summary>
        /// Returns a dimension expression of the form RxCxWw where 
        /// R := row count
        /// C := column count
        /// W := cell width
        /// </summary>
        public string Format()
            => $"{RowCount}x{ColCount}x{CellWidth}w";
    }
}