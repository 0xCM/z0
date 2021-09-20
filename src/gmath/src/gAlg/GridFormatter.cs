//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;

    public readonly struct GridFormatter
    {
        public static void render(int segwidth, int kMinSegs, int mkMaxSgs, ITextBuffer dst)
        {
            dst.AppendLine(Grids.statsheader());
            var points = (
                from row in gAlg.stream(kMinSegs, mkMaxSgs)
                from col in gAlg.stream(kMinSegs, mkMaxSgs)
                let count = row*col
                orderby count
                select (row, col)).ToArray();

            for(var i = 0; i<points.Length; i++)
            {
                var stats = CellCalcs.metrics((ushort)points[i].row, (ushort)points[i].col, (ushort)segwidth).Stats;
                if(stats.Vec256Remainder == 0 || stats.Vec128Remainder == 0)
                    dst.AppendLine(Grids.format(stats));
            }
        }
    }
}