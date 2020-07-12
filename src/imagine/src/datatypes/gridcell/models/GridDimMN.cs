//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static z;

    /// <summary>
    /// Encapsulates metrics that characterize a grid of natural rectangular dimensions
    /// </summary>
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
            get => GridCells.tablebits<M,N>();
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => (int)value<M>();
        }

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount
        {
            [MethodImpl(Inline)]
            get => (int)value<N>();
        }

        /// <summary>
        /// The bit width of a storage cell
        /// </summary>
        public int CellWidth
        {
            [MethodImpl(Inline)]
            get => (int)bitsize<T>();
        }

        /// <summary>
        /// The bit width of a storage block
        /// </summary>
        public int BlockWidth
        {
            [MethodImpl(Inline)]
            get => (int)bitsize<T>();
        }

        /// <summary>
        /// The number of cells required cover a grid
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => GridCells.tablecells<M,N,T>();
        }
        
        /// <summary>
        /// The number of bytes required to cover a grid
        /// </summary>
        public int ByteCount
        {
            [MethodImpl(Inline)]
            get => GridCells.tablesize<M,N>();
        }

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