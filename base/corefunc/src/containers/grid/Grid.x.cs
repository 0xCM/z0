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

    partial class xfunc
    {        
        public static string Format(this GridMap layout)
        {
            var format = sbuild();
            format.AppendLine($"{layout.RowCount}x{layout.ColCount}x{layout.SegWidth}");
            var cells = new CellMap[layout.ColCount];
            for(var row = 0; row<layout.RowCount; row++)
            {
                //var cells = layout.Row(row);
                layout.Row(row, cells);                
                for(var i=0; i<cells.Length; i++)
                    format.AppendLine(cells[i].Format());
            }
            return format.ToString();
        }

        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        /// <typeparam name="T">The storage type</typeparam>
        public static GridMap ToGridMap(this GridSpec spec)
            => GridLayout.map(spec);


    }

}