//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines primary grid indexing api surface
    /// </summary>
    public static class GridLayout
    {        
        /// <summary>
        /// Specifies a grid predicated on supplied arguments
        /// </summary>
        /// <param name="RowCount">The number of rows in the grid</param>
        /// <param name="ColCount">The number of columns in the grid</param>
        /// <param name="CellWidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridSpec specify(uint RowCount, uint ColCount, uint CellWidth)    
            => new GridSpec(RowCount, ColCount, CellWidth);

        /// <summary>
        /// Specifies a grid predicated on type parameters
        /// </summary>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        public static GridSpec specify<M,N,T>(M m = default, N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => new GridSpec(unat<M>(), unat<N>(), bitsize<T>());

        /// <summary>
        /// Defines a grid map predicated row count, col count and cell width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="capacity">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridMap map(uint rows, uint cols, uint capacity)    
            => map(specify(rows,cols, capacity));

        /// <summary>
        /// Defines a grid map predicated on type parameters
        /// </summary>
        /// <param name="RowCount">The number of rows in the grid</param>
        /// <param name="ColCount">The number of columns in the grid</param>
        /// <param name="CellWidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridMap map<M,N,T>(M m = default, N n = default, T zero = default)    
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => map(specify(m,n, zero));

        /// <summary>
        /// Defines a grid map predicated on an existing specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        public static GridMap map(GridSpec spec)
            => new GridMap(spec, spec.GridCells());

        /// <summary>
        /// Computes the minimum number of storage segments required to store a grid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The numbet of grid columns</param>
        /// <param name="segwidth">The bit-width of a segment</param>
		[MethodImpl(Inline)]
        public static BitSize storage(uint rows, uint cols, BitSize segwidth)
        {
            var vol = (int)(rows*cols);
            var q = Math.DivRem(vol, segwidth, out int r);
            return  q + (r != 0 ? segwidth : BitSize.Zero);
        }

        /// <summary>
        /// Computes the minimum number of storage segments required to store a grid
        /// predicated on the bit width parametric type
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The numbet of grid columns</param>
        /// <param name="capacity">The bit-width of a segment</param>
        /// <typeparam name="T">The storage segment</typeparam>
		[MethodImpl(Inline)]
        public static BitSize storage<T>(uint rows, uint cols)
            where T : unmanaged
                => storage(rows,cols, bitsize<T>());

        /// <summary>
        /// Computes the minimum number of bytes required to store a grid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The numbet of grid columns</param>
        [MethodImpl(Inline)]
        public static BitSize storage(uint rows, uint cols)
            => storage(rows, cols, 8);

        static IEnumerable<CellMap> GridCells(this GridSpec spec)
        {                                                        
            var pos = 0u;
            ushort segment = 0;
            ushort offset = 0;
            var capacity = spec.SegWidth;
            var remaining = capacity;
            for(var i=0; i < spec.RowCount; i++)
            {
                for(var j = 0; j < spec.ColCount; j++)
                {
                    
                    var index = CellIndex.Define(segment, offset++, pos++);   
                    yield return new CellMap(index, (ushort)i, (ushort)j);                     
                    
                    if(--remaining == 0)
                    {
                        segment++;
                        remaining = capacity;
                        offset = 0;
                    }
                }
            }
        }   

    }

}