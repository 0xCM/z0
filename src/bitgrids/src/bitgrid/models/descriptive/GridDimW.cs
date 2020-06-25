//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static Memories;


    /// <summary>
    /// Defines a parametrically-predicated blocked grid
    /// </summary>
    public readonly struct GridDim<W,M,N,T> : IGridDim<W,M,N,T>
        where W : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        /// <summary>
        /// The bit width of a block
        /// </summary>
        public int BlockWidth
        {
            [MethodImpl(Inline)]
            get => nati<W>();
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => nati<M>();
        }

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount
        {
            [MethodImpl(Inline)]
            get => nati<N>();
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
        /// The total number of grid bits
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.tablebits<M,N>();
        }

        /// <summary>
        /// The number of cells required cover a grid
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.tablecells<M,N,T>();
        }

        /// <summary>
        /// The number of bytes required to cover a grid
        /// </summary>
        public int ByteCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.tablesize<M,N>();
        }


        /// <summary>
        /// Computes the aligned number of W-blocks required to cover M*N bits
        /// </summary>
        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => Blocks.cellcover<W,M,N,T>();
        }

        /// <summary>
        /// Computes the number of cells covered by a block
        /// </summary>
        public int BlockLength
        {
            [MethodImpl(Inline)]
            get => Blocks.length<W,T>();
        }

        /// <summary>
        /// Returns a dimension expression of the form {R}x{C}x{W}w where 
        /// R := row count
        /// C := column count
        /// W := cell width
        /// </summary>
        public string Format()
            => $"{BlockWidth}::{RowCount}x{ColCount}x{CellWidth}w";
    }
}