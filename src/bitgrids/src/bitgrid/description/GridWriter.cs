//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Linq;

    public readonly struct GridWriter
    {
        public static GridWriter Create()
            => default(GridWriter);
            
        public void Save(int segwidth, int minsegs, int maxsegs, FolderPath dst)
        {
            var filename = FileName.Define($"GridMap{segwidth}.csv");
            var dstpath = dst + filename;
            Save(segwidth,minsegs,maxsegs, dstpath);
        }

        public void Save(int segwidth, int minsegs, int maxsegs, FilePath path)
        {
            using var dst = path.Writer();
            dst.WriteLine(FormatHeader());
            var points = (
                from row in gmath.range(minsegs,maxsegs)
                from col in gmath.range(minsegs,maxsegs)
                let count = row*col
                orderby count
                select (row, col)).ToArray();

            for(var i = 0; i<points.Length; i++)
            {                    
                var gs = BitGrid.gridmap((ushort)points[i].row, (ushort)points[i].col, (ushort)segwidth).Stats();
                    if(gs.Vec256Remainder == 0 || gs.Vec128Remainder == 0)
                        dst.WriteLine(Format(gs));
            }
                            
            dst.Flush();
        }
 
        public string Format(GridStats stats, int? colpad = null, char? delimiter = null)
        {
            var format = text.build();
            var pad = colpad ?? 10;
            var sep = delimiter ?? Chars.Pipe;
            format.Append($"{stats.Name}".PadRight(pad));
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
        /// Defines a standard header for a grid map summary line
        /// </summary>
        /// <param name="colpad">The amount by which to pad each column</param>
        /// <param name="delimiter">The column separator</param>
        static string FormatHeader(int? colpad = null, char? delimiter = null)
        {
            var pad = colpad ?? 10;
            var sep = delimiter ?? Chars.Pipe;
            var format = text.build();
            format.Append($"name".PadRight(pad));
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
    }
}