//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
            void Emit(int segwidth, int minsegs, int maxsegs)
            {
                var filename = FileName.Define($"GridMap{segwidth}.csv");
                using var dst = LogArea.Test.LogWriter(filename);
                dst.WriteLine(BitGrid.header());
                var points = (
                    from r1 in range(minsegs,maxsegs)
                    from r2 in range(minsegs,maxsegs)
                    let count = r1*r2
                    orderby count
                    select (r1, r2)).ToArray();

                for(var i = 0; i<points.Length; i++)
                {
                    (var r, var c) = points[i];
                    var gs = BitGrid.map(r,c,segwidth).Stats();
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