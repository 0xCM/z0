//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class GridMap
    {        
        /// <summary>
        /// Defines a grid map predicated row count, col count and storage segment bit width width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridMap Define(ushort rows, ushort cols, ushort segwidth)    
            => Define(GridSpec.Define(rows,cols, segwidth));

        /// <summary>
        /// Defines a grid map predicated row count, col count and the bit width of parametric type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        [MethodImpl(NotInline)]
        public static GridMap Define<T>(ushort rows, ushort cols)    
            where T : unmanaged
                => Define(GridSpec.Define<T>(rows,cols));

        /// <summary>
        /// Defines a grid map predicated on type parameters
        /// </summary>
        /// <param name="RowCount">The number of rows in the grid</param>
        /// <param name="ColCount">The number of columns in the grid</param>
        /// <param name="CellWidth">The width of a grid cell</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static GridMap Define<M,N,T>(M m = default, N n = default, T zero = default)    
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => Define(GridSpec.Define(m,n, zero));

        /// <summary>
        /// Defines a grid map predicated on an existing specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        public static GridMap Define(in GridSpec spec)
            => new GridMap(spec);
         
        public GridMap(in GridSpec spec)
        {
            this.RowCount = spec.RowCount;
            this.ColCount = spec.ColCount;
            this.SegWidth = spec.SegWidth;
            this.StorageBits = spec.StorageBits;
            this.StorageBytes = spec.StorageBytes;
            this.SegCount = spec.StorageSegs;                        
        }        

        public GridMap(ushort rows, ushort cols, ushort segwidth)
        {
            this.RowCount = rows;
            this.ColCount = cols;
            this.SegWidth = segwidth;
            var spec = GridSpec.Define(rows, cols, segwidth);
            this.StorageBits = spec.StorageBits;
            this.StorageBytes = spec.StorageBytes;
            this.SegCount = spec.StorageSegs;                        
        }        

        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public readonly ushort RowCount;
        
        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public readonly ushort ColCount;

        /// <summary>
        /// The number of bits in a segment
        /// </summary>
        public readonly ushort SegWidth;
            
        /// <summary>
        /// The number of segment-aligned bits required for storage
        /// </summary>
        public readonly int StorageBits;

        /// <summary>
        /// The number of segment-aligned bytes bits required for storage
        /// </summary>
        public readonly int StorageBytes;

        /// <summary>
        /// The number of segment-aligned storage segments
        /// </summary>
        public readonly int SegCount;

        /// <summary>
        /// The number bytes that do not fit into a whole number of 128-bit vectors
        /// </summary>
        public int Vec128Remainder  
        {
            [MethodImpl(Inline)]
            get => StorageBytes % 16;
        }

        /// <summary>
        /// The number of whole 128-bit vectors required for storage
        /// </summary>
        public int Vec128Count 
        {
            [MethodImpl(Inline)]
            get => StorageBytes/16 + (Vec128Remainder != 0 ? 1 : 0);
        }

        /// <summary>
        /// The number of whole 256-bit vectors required for storage
        /// </summary>
        public int Vec256Count 
        {
            [MethodImpl(Inline)]
            get => StorageBytes / 32 + (Vec256Remainder != 0 ? 1 : 0);
        }
            
        /// <summary>
        /// The number bytes that do not fit into a whole number of 256-bit vectors
        /// </summary>
        public int Vec256Remainder 
        {
            [MethodImpl(Inline)]
            get => StorageBytes % 32;
        }

        /// <summary>
        /// The total number of items covered by the grid
        /// </summary>
        public int PointCount 
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;     
        }

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public int Pos(int row, int col)
            => BitCalcs.bitindex(ColCount, row,col);

        /// <summary>
        /// Computes the storage segment offset for a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public int Offset(int row, int col)
            => Pos(row,col) % SegWidth;

        /// <summary>
        /// Computes the storage segment that covers a specifed row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public int Seg(int row, int col)
            => Pos(row,col) / SegWidth;            
    }
}