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
        public static BitGridLayout<T> CalcLayout<T>(this BitGridSpec<T> spec)
            where T : unmanaged
                => new BitGridLayout<T>(spec, spec.GridCells());

        static IEnumerable<BitCellMap<T>> GridCells<T>(this BitGridSpec<T> spec)
            where T : unmanaged
        {                                                        
            var bit = 0;
            var seg = 0;
            var segbits = spec.CellSize;

            for(int row = 0, rowbit = 0; row < spec.RowCount; row++)
            {
                for(var col = 0; col < spec.ColCount; col++, bit++, rowbit++, segbits--)
                {
                    if(segbits == 0)
                    {
                        seg++;
                        segbits = spec.CellSize;
                    }
                   
                   var offset = (byte)(spec.CellSize - segbits).Bits;
                   var pos = BitCellIndex<T>.Define((ushort)seg,offset);
                   yield return  new BitCellMap<T>(pos.Segment, pos.Offset, pos.LinearIndex, row, col);
                }

                seg++;
                segbits = spec.CellSize;
            }                    
        }   
    }
}