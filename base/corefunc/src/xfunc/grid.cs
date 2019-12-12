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

    public static class GridLayoutX
    {
        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitGridLayout CalcLayout<T>(this BitGridSpec spec)
            where T : unmanaged
                => new BitGridLayout(spec, spec.GridCells<T>());

        static IEnumerable<BitCellMap> GridCells<T>(this BitGridSpec spec)
            where T : unmanaged
        {                                                        
            var bit = 0;
            var seg = 0;
            var segbits = spec.CellWidth;

            for(int row = 0, rowbit = 0; row < spec.RowCount; row++)
            {
                for(var col = 0; col < spec.ColCount; col++, bit++, rowbit++, segbits--)
                {
                    if(segbits == 0)
                    {
                        seg++;
                        segbits = spec.CellWidth;
                    }
                   
                   var offset = (byte)(spec.CellWidth - segbits);
                   var pos = BitCellIndex<T>.Define((ushort)seg,offset);
                   yield return  new BitCellMap(pos.Segment, pos.Offset, pos.LinearIndex, row, col);
                }

                seg++;
                segbits = spec.CellWidth;
            }                    
        }   
    }
}