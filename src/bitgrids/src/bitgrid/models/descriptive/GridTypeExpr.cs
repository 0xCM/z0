//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static Typed;
    using static Root;
    
    [ApiHost]
    public readonly struct GridTypeExpr
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static GridTypeExpr<N64,N8,N8,T> define<T>(T t = default)
            where T : unmanaged
                => define(n64, n8,n8, t);
        
        /// <summary>
        /// Defines a parametrically-specified grid type expression
        /// </summary>
        /// <typeparam name="W">The block width type</typeparam>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static GridTypeExpr<W,M,N,T> define<W,M,N,T>(W w = default, M m = default, N n = default, T t = default)
            where W : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;
    }

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
        public asci8 BlockWidth 
        {
            [MethodImpl(Inline)]
            get => $"{default(W).NatValue}";
        }

        /// <summary>
        /// Specifies the M-identified number of rows in the grid
        /// </summary>
        public asci8 RowCount         
        {
            [MethodImpl(Inline)]
            get=> $"{default(M).NatValue}";
        }

        /// <summary>
        /// Specifies the number of N-columns in the grid
        /// </summary>
        public asci8 ColCount 
        {
            [MethodImpl(Inline)]
            get => $"{default(N).NatValue}";
        }

        /// <summary>
        /// Specifies the bit width of a T-cell
        /// </summary>
        public asci8 CellWidth 
        {
            [MethodImpl(Inline)]
            get => $"{bitsize<T>()}";
        }

        public asci8 BitCount        
        {
            [MethodImpl(Inline)]
            get => $"{BitCalcs.tablebits<M,N>()}";
        }
    
        public asci8 CellCount
        {
            [MethodImpl(Inline)]
            get => $"{BitCalcs.tablecells<M,N,T>()}";
        }

        public asci8 BytCount
        {
            [MethodImpl(Inline)]
            get => $"{Cells.tablesize<M,N>()}";
        }

        /// <summary>
        /// Specifies the aligned number of W-blocks required to cover M*N bits
        /// </summary>
        public asci8 BlockCount
        {
            [MethodImpl(Inline)]
            get => $"{Blocks.cellcover<W,M,N,T>()}";
        }

        /// <summary>
        /// Specifies the number of cells covered by a block
        /// </summary>
        public asci8 BlockLength
        {
            [MethodImpl(Inline)]
            get => $"{Blocks.length<W,T>()}";
        }
    }
}