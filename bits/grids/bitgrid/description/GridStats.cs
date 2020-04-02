//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    
    public class ColInfoAttribute : Attribute
    {
        public ColInfoAttribute(string Name, string desc = "", int Width = 0)
        {
            this.Name = Name;
            this.Desc = desc;
            this.Width = Width == 0 ? (int?)null : Width;
        }
        
        public string Name {get;}

        public string Desc {get;}
        
        public int? Width {get;}
    }

    public class GridStats
    {        
        /// <summary>
        /// Computes grid map summary information
        /// </summary>
        /// <param name="map">The map to summarize</param>
        [MethodImpl(Inline)]
        public static GridStats Define<T>(ushort rows, ushort cols)
            where T : unmanaged
                => Define(GridMap.Define(GridSpec.Define<T>(rows,cols)));

        /// <summary>
        /// Computes grid map summary information
        /// </summary>
        /// <param name="map">The map to summarize</param>
        [MethodImpl(Inline)]
        public static GridStats Define(ushort rows, ushort cols, ushort segwidth)
            => Define(GridMap.Define(GridSpec.Define(rows,cols,segwidth)));

        /// <summary>
        /// Defines a standard header for a grid map summary line
        /// </summary>
        /// <param name="colpad">The amount by which to pad each column</param>
        /// <param name="delimiter">The column separator</param>
        public static string FormatHeader(int? colpad = null, char? delimiter = null)
        {
            var pad = colpad ?? 10;
            var sep = delimiter ?? Chars.Pipe;
            var format = text.factory.Builder();
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

        public static string Format(GridStats stats, int? colpad = null, char? delimiter = null)
        {
            var format = text.factory.Builder();
            var pad = colpad ?? 10;
            var sep = delimiter ?? Chars.Pipe;
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


        [MethodImpl(Inline)]
        public static GridStats Define(GridMap src)
            => new GridStats
            {
                RowCount = src.RowCount,
                ColCount = src.ColCount,
                SegWidth = src.SegWidth,
                SorageSegs = src.SegCount,
                StorageBits = src.StorageBits,
                StorageBytes = src.StorageBytes,
                PointCount = src.PointCount,
                Vec128Count = src.Vec128Count,
                Vec128Remainder = src.Vec128Remainder,
                Vec256Count = src.Vec256Count,
                Vec256Remainder = src.Vec256Remainder
            };
        
        GridStats()
        {

        }


        /// <summary>
        /// The number of grid rows
        /// </summary>
        [ColInfo("rows","The number of grid rows")]
        public ushort RowCount {get;set;}
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        [ColInfo("cols","The number of grid columns")]
        public ushort ColCount {get;set;}

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        [ColInfo("segsize","The number of bits in a storage segment")]
        public ushort SegWidth {get;set;}

        /// <summary>
        /// The number of points covered by the grid
        /// </summary>
        [ColInfo("points", "The number of points covered by the grid")]
        public int PointCount {get;set;}

        /// <summary>
        /// The number of segment-aligned segments required for storage
        /// </summary>
        [ColInfo("segs","The number of segment-aligned segments required for storage")]
        public int SorageSegs {get;set;}

        /// <summary>
        /// The number of segment-aligned bits required for storage
        /// </summary>
        [ColInfo("bits","The number of segment-aligned bits required for storage")]
        public int StorageBits {get;set;}

        /// <summary>
        /// The number of segment-aligned bytes bits required for storage
        /// </summary>
        [ColInfo("bytes","The number of segment-aligned bytes bits required for storage")]
        public int StorageBytes {get;set;}
            
        /// <summary>
        /// The number of whole 128-bit vectors required for storage
        /// </summary>
        [ColInfo("v128","The number of whole 128-bit vectors required for storage")]
        public int Vec128Count {get;set;}

        /// <summary>
        /// The number bytes that do not fit into a whole number of 128-bit vectors
        /// </summary>
        [ColInfo("v128/r")]
        public int Vec128Remainder  {get;set;}
        
        /// <summary>
        /// The number of whole 256-bit vectors required for storage
        /// </summary>
        [ColInfo("v256")]
        public int Vec256Count {get;set;}
            
        /// <summary>
        /// The number bytes that do not fit into a whole number of 256-bit vectors
        /// </summary>
        [ColInfo("v256/r")]
        public int Vec256Remainder {get;set;}            
    }
}