//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Charcterizes a bitgrid and consequent attribute expressions
    /// </summary>
    /// <typeparam name="W">The block width type</typeparam>
    /// <typeparam name="M">The row count type</typeparam>
    /// <typeparam name="N">The column count type</typeparam>
    /// <typeparam name="T">The storage cell type</typeparam>
    public readonly struct GridTypeExpr<W,M,N,T>
        where W : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        /// <summary>
        /// Specifies the bit width block as determined by W
        /// </summary>
        public uint BlockWidth
        {
            [MethodImpl(Inline)]
            get => (uint)default(W).NatValue;
        }

        /// <summary>
        /// Specifies the M-identified number of rows in the grid
        /// </summary>
        public uint RowCount
        {
            [MethodImpl(Inline)]
            get=> (uint)default(M).NatValue;
        }

        /// <summary>
        /// Specifies the number of N-columns in the grid
        /// </summary>
        public uint ColCount
        {
            [MethodImpl(Inline)]
            get => (uint)default(N).NatValue;
        }

        /// <summary>
        /// Specifies the bit width of a T-cell
        /// </summary>
        public uint CellWidth
        {
            [MethodImpl(Inline)]
            get => width<T>();
        }

        public uint BitCount
        {
            [MethodImpl(Inline)]
            get => (uint)NatCalc.mul<M,N>();
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)CellCalcs.gridcells<M,N,T>();
        }

        public uint BytCount
        {
            [MethodImpl(Inline)]
            get => (uint)CellCalcs.gridsize<M,N>();
        }

        /// <summary>
        /// Specifies the aligned number of W-blocks required to cover M*N bits
        /// </summary>
        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => (uint)CellCalcs.cellcover<W,M,N,T>();
        }

        /// <summary>
        /// Specifies the number of cells covered by a block
        /// </summary>
        public uint BlockLength
        {
            [MethodImpl(Inline)]
            get => (uint)CellCalcs.cells<W,T>();
        }
    }
}