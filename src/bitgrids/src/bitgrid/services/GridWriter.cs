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

        public void Save(int segwidth, int kMinSegs, int mkMaxSgs, FS.FolderPath dst)
        {
            var filename = FS.file($"GridMap{segwidth}.csv");
            var dstpath = dst + filename;
            Save(segwidth,kMinSegs,mkMaxSgs, dstpath);
        }

        public void Save(int segwidth, int kMinSegs, int mkMaxSgs, FS.FilePath path)
        {
            using var dst = path.Writer();
            dst.WriteLine(Grids.header());
            var points = (
                from row in gAlg.stream(kMinSegs, mkMaxSgs)
                from col in gAlg.stream(kMinSegs, mkMaxSgs)
                let count = row*col
                orderby count
                select (row, col)).ToArray();

            for(var i = 0; i<points.Length; i++)
            {
                var gs = CellCalcs.metrics((ushort)points[i].row, (ushort)points[i].col, (ushort)segwidth).Stats();
                if(gs.Vec256Remainder == 0 || gs.Vec128Remainder == 0)
                    dst.WriteLine(Grids.format(gs));
            }

            dst.Flush();
        }
    }
}