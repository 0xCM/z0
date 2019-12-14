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
    using static As;

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
            var cellindex = 0;
            var cellbits = spec.CellWidth;

            for(int row = 0, rowbit = 0; row < spec.RowCount; row++)
            {
                for(var col = 0; col < spec.ColCount; col++, bit++, rowbit++, cellbits--)
                {
                    if(cellbits == 0)
                    {
                        cellindex++;
                        cellbits = spec.CellWidth;
                    }
                   
                   var bitoffset = uint8(spec.CellWidth - cellbits);
                   var bitindex = uint8(cellindex * spec.CellWidth + bitoffset);
                   yield return  new BitCellMap(uint16(cellindex), bitoffset, bitindex, row, col);
                }

                cellindex++;
                cellbits = spec.CellWidth;
            }                    
        }   
    }
}