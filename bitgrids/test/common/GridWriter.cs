//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class GridWriter
    {
        public static void EmitGridMaps()
        {
            void Emit(ushort segwidth, ushort minsegs, ushort maxsegs)
            {
                var filename = FileName.Define($"GridMap{segwidth}.csv");
                using var dst = LogArea.Test.LogWriter(filename);
                dst.WriteLine(GridStats.FormatHeader());
                var points = (
                    from row in Numeric.range(minsegs,maxsegs)
                    from col in Numeric.range(minsegs,maxsegs)
                    let count = row*col
                    orderby count
                    select (row, col)).ToArray();

                for(var i = 0; i<points.Length; i++)
                {                    
                    var gs = GridMap.Define(points[i].row, points[i].col, segwidth).Stats();
                        if(gs.Vec256Remainder == 0 || gs.Vec128Remainder == 0)
                            dst.WriteLine(gs.Format());
                }
                             
                dst.Flush();
            }

            Emit(8, 1, 256);
            Emit(16,1, 256);
            Emit(32,1, 256);
            Emit(64,1, 256);

        }

    }

}