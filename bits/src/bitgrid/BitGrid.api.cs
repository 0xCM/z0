//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;
    using static AsIn;

    public static partial class BitGrid
    {
        [MethodImpl(Inline)]
        public static GridMoniker moniker(int rows, int cols, int segwidth)
            => GridMoniker.Define((ushort)rows,(ushort)cols,(ushort)segwidth);

        [MethodImpl(Inline)]
        public static GridMoniker<T> moniker<T>(int rows, int cols)
            where T : unmanaged
                => GridMoniker.Define<T>((ushort)rows,(ushort)cols);

        [MethodImpl(Inline)]
        public static int minbytes(in GridMoniker moniker)    
            => minbytes(moniker.RowCount, moniker.ColCount);

        /// <summary>
        /// Computes the minimum number of segments required to store a grid of specified dimensions
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <param name="segwidth">The segment bit width</param>
        [MethodImpl(Inline)]
        public static int segcount(in GridMoniker moniker)
        {
            var bytes = minbytes(moniker);
            var segbytes = moniker.SegWidth / 8;
            var segs = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);            
            return segs;
        }

        [MethodImpl(Inline)]
        public static GridSpec specify(in GridMoniker moniker)    
            => specify(moniker.RowCount, moniker.ColCount, moniker.SegWidth);

        [MethodImpl(Inline)]
        public static GridMap map(in GridMoniker moniker)
            => map(specify(moniker));

        [MethodImpl(Inline)]
        public static GridStats stats(in GridMoniker moniker)
            => stats(map(moniker));

        /// <summary>
        /// Allocates a generic bitgrid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> alloc<T>(in GridMoniker<T> moniker)
            where T : unmanaged
                => alloc<T>(moniker.RowCount, moniker.ColCount);

        /// <summary>
        /// Loads a generic bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="map">The grid map</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> load<T>(Span<T> src, in GridMoniker<T> moniker)
            where T : unmanaged
                => load(src, moniker.RowCount, moniker.ColCount);

        /// <summary>
        /// Allocates a generic bitgrid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> alloc<T>(int rows, int cols)
            where T : unmanaged
        {
            var map = map<T>(rows,cols);
            Span<T> data = new T[map.SegCount];
            return new BitGrid<T>(data,rows, cols);
        }

        /// <summary>
        /// Allocates a bitgrid of natural dimensions
        /// </summary>
        /// <typeparam name="M">The number of rows in the grid</typeparam>
        /// <typeparam name="N">The number of columns in the grid</typeparam>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> alloc<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var layout = map(m,n,zero);
            Span<T> data = new T[layout.SegCount];
            return new BitGrid<M, N, T>(data);
        }

        /// <summary>
        /// Loads a generic bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="map">The grid map</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> load<T>(Span<T> src, int rows, int cols)
            where T : unmanaged
                => new BitGrid<T>(src, rows, cols);

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var layout = map(m,n,zero);
            require(src.Length == layout.SegCount);
            return new BitGrid<M, N, T>(src);
        }

        [MethodImpl(Inline)]
        public static void fill<T>(BitGrid<T> grid, bit state)    
            where T : unmanaged
                => grid.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());

        [MethodImpl(Inline)]
        public static void fill<M,N,T>(BitGrid<M,N,T> grid, bit state)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => grid.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());
  
        /// <summary>
        /// Computes the minimum number of bytes required to store a grid of specified dimensions
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline)]
        public static int minbytes(int rows, int cols)
        {
            var points = rows*cols;
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }
        
        /// <summary>
        /// Computes the minimum number of bytes required to store a grid of specified dimensions
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        [MethodImpl(Inline)]
        public static int minbytes<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var points = NatMath.mul(m,n);
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }
                    
        /// <summary>
        /// Computes the minimum number of segments required to store a grid of specified dimensions
        /// </summary>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="w">The segment bit width</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        [MethodImpl(Inline)]
        static int segcountW<M,N,W>(M m = default, N n = default, W w = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where W : unmanaged, ITypeNat
        {                
            var bytes = minbytes(m,n);    
            var segbytes = NatMath.div(w,n8);
            var segs =  bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);            
            return segs;
        }

        [MethodImpl(Inline)]
        public static int segcount<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return segcountW(m,n,n8);
            else if(typeof(T) == typeof(ushort))
                return segcountW(m,n,n16);                
            else if(typeof(T) == typeof(uint))
                return segcountW(m,n,n32);                
            else if(typeof(T) == typeof(ulong))
                return segcountW(m,n,n64);                
            else
                throw unsupported<T>();
        } 

        /// <summary>
        /// Defines a grid specification predicated on specified row count, col count and bit width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridSpec specify(int rows, int cols, int segwidth)    
        { 
            var bytes = minbytes(rows,cols);
            var segbytes = segwidth >> 3;
            var segs = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);            
            return new GridSpec(rows: rows, cols : cols, segwidth : segwidth, bytes: bytes, bits: bytes*8, segs: segs);
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
         
        [MethodImpl(Inline)]
        public static GridSpec specify<M,N,T>(M m = default, N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => specify<T>(natval<M>(), natval<N>());

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

            var cells = new CellMap[spec.RowCount * spec.ColCount];
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
        

    }

    class BitGridInfo<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static readonly GridMap Map = BitGrid.map<M,N,T>();
    }
}