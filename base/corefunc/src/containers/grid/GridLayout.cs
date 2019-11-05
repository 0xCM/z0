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
        /// Defines a grid specification predicated on specified row count, col count and bit width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridSpec specify(int rows, int cols, int segwidth)    
        { 
            var points = rows*cols;
            var bytes = Mod8.div(points) + (Mod8.mod(points) != 0 ? 1 : 0);
            var bits = bytes *8;
            var segbytes = Mod8.div(segwidth); 
            var segs = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);            
            return new GridSpec(rows: rows, cols : cols, segwidth : segwidth, points : points, bytes: bytes, bits: bits, segs: segs);
        }            

        /// <summary>
        /// Defines a grid specification predicated on specified row count, col count and bit width of a parametric type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        [MethodImpl(Inline)]
        public static GridSpec specify<T>(int rows, int cols) 
            where T : unmanaged   
                => specify(rows, cols, bitsize<T>());

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
                => specify(inat<M>(), inat<N>(), bitsize<T>());

        /// <summary>
        /// Defines a grid map predicated row count, col count and storage segment bit width width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridMap map(int rows, int cols, int segwidth)    
            => map(specify(rows,cols, segwidth));

        /// <summary>
        /// Defines a grid map predicated row count, col count and the bit width of parametric type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        [MethodImpl(NotInline)]
        public static GridMap map<T>(int rows, int cols)    
            where T : unmanaged
                => map(specify<T>(rows,cols));

        /// <summary>
        /// Defines a grid map predicated on type parameters
        /// </summary>
        /// <param name="RowCount">The number of rows in the grid</param>
        /// <param name="ColCount">The number of columns in the grid</param>
        /// <param name="CellWidth">The width of a grid cell</param>
        /// <typeparam name="T">The storage segment type</typeparam>
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
        public static GridMap map(in GridSpec spec)
            => new GridMap(spec);

        /// <summary>
        /// Computes the minimum number of storage segments required to store a grid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The numbet of grid columns</param>
        /// <param name="segwidth">The bit-width of a segment</param>
		[MethodImpl(Inline)]
        public static int storage(int rows, int cols, int segwidth)
        {
            var vol = rows*cols;
            var q = vol / segwidth;
            var r = vol % segwidth;            
            return  q + (r != 0 ? segwidth : 0);
        }

        /// <summary>
        /// Computes the segments required to store a grid predicated on specified dimensions and the bit width of a parametric type
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The numbet of grid columns</param>
        /// <param name="capacity">The bit-width of a segment</param>
        /// <typeparam name="T">The storage segment type</typeparam>
		[MethodImpl(Inline)]
        public static BitSize storage<T>(int rows, int cols)
            where T : unmanaged
                => storage(rows,cols, bitsize<T>());

        /// <summary>
        /// Computes grid map summary information
        /// </summary>
        /// <param name="map">The map to summarize</param>
        [MethodImpl(Inline)]
        public static GridStats stats(GridMap map)
            => GridStats.Define(map);

        /// <summary>
        /// Computes grid map summary information
        /// </summary>
        /// <param name="map">The map to summarize</param>
        [MethodImpl(Inline)]
        public static GridStats stats<T>(int rows, int cols)
            where T : unmanaged
                => stats(map(specify<T>(rows,cols)));

        /// <summary>
        /// Computes grid map summary information
        /// </summary>
        /// <param name="map">The map to summarize</param>
        [MethodImpl(Inline)]
        public static GridStats stats(int rows, int cols, int segwidth)
            => stats(map(specify(rows,cols,segwidth)));

        /// <summary>
        /// Defines a standard header for a grid map summary line
        /// </summary>
        /// <param name="colpad">The amount by which to pad each column</param>
        /// <param name="delimiter">The column separator</param>
        public static string header(int? colpad = null, char? delimiter = null)
        {
            var pad = colpad ?? 10;
            var sep = delimiter ?? AsciSym.Pipe;
            var format = sbuild();
            format.Append($"moniker".PadRight(pad));
            format.Append($" {sep} rows".PadRight(pad));
            format.Append($" {sep} cols".PadRight(pad));
            format.Append($" {sep} segsize".PadRight(pad));
            format.Append($" {sep} points".PadRight(pad));
            format.Append($" {sep} segs".PadRight(pad));
            format.Append($" {sep} bits".PadRight(pad));
            format.Append($" {sep} bytes".PadRight(pad));
            format.Append($" {sep} v128".PadRight(pad));
            format.Append($" {sep} v128/r".PadRight(pad));
            format.Append($" {sep} v256".PadRight(pad));
            format.Append($" {sep} v256/r".PadRight(pad));
            return format.ToString();

        }

        public static string format(GridStats stats, int? colpad = null, char? delimiter = null)
        {
            var format = sbuild();
            var pad = colpad ?? 10;
            var sep = delimiter ?? AsciSym.Pipe;
            format.Append($"{stats.Moniker}".PadRight(pad));
            format.Append($" {sep} {stats.RowCount}".PadRight(pad));
            format.Append($" {sep} {stats.ColCount}".PadRight(pad));
            format.Append($" {sep} {stats.SegWidth}".PadRight(pad));
            format.Append($" {sep} {stats.PointCount}".PadRight(pad));
            format.Append($" {sep} {stats.SorageSegs}".PadRight(pad));
            format.Append($" {sep} {stats.StorageBits}".PadRight(pad));
            format.Append($" {sep} {stats.StorageBytes}".PadRight(pad));
            format.Append($" {sep} {stats.Vec128Count}".PadRight(pad));
            format.Append($" {sep} {stats.Vec128Remainder}".PadRight(pad));
            format.Append($" {sep} {stats.Vec256Count}".PadRight(pad));
            format.Append($" {sep} {stats.Vec256Remainder}".PadRight(pad));
            return format.ToString();
        }

        /// <summary>
        /// Renders a textual description of a grid map
        /// </summary>
        /// <param name="layout">The map to be described</param>
        /// <param name="colpad"></param>
        /// <param name="delimiter"></param>
        public static string format(GridMap layout, int? colpad = null, char? delimiter = null)
            => format(layout, colpad, delimiter);

        public static CellMap[] cells(this GridSpec spec)
        {
            var pos = 0u;
            ushort segment = 0;
            ushort offset = 0;
            var capacity = spec.SegWidth;
            var remaining = capacity;

            var cells = new CellMap[spec.PointCount];
            for(var i=0; i<spec.RowCount; i++)
            for(int j=0; j<spec.ColCount; j++, pos++)
            {
                cells[pos] = new CellMap(pos, segment, offset++, (ushort)i, (ushort)j);

                if(--remaining == 0)
                {
                    segment++;
                    remaining = capacity;
                    offset = 0;
                }
            }
            return cells;
        }
        
        public static IEnumerable<CellMap> GridCells(this GridSpec spec)
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