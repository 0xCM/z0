//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IGridDim
    {
        /// <summary>
        /// The numbet of rows in the grid
        /// </summary>
        int RowCount {get;}
        
        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        int ColCount {get;}    
    }

    /// <summary>
    /// Characterizes a grid with parametric cell type
    /// </summary>
    /// <typeparam name="T">The grid cell type</typeparam>
    public interface   IGridDim<T> : IGridDim
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a grid with parametric row, column and cell types
    /// </summary>
    /// <typeparam name="T">The grid cell type</typeparam>
    /// <typeparam name="M">The grid row type</typeparam>
    /// <typeparam name="N">The grid col type</typeparam>
    public interface IGridDim<M,N,T> : IGridDim<T>, IDim<M,N>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a grid with parametric block width, row, column and cell types
    /// </summary>
    /// <typeparam name="W">The grid block type</typeparam>
    /// <typeparam name="M">The grid row type</typeparam>
    /// <typeparam name="N">The grid col type</typeparam>
    /// <typeparam name="T">The grid cell type</typeparam>
    public interface IGridDim<W,M,N,T> : IGridDim<M,N,T>
        where W : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        
    }
}