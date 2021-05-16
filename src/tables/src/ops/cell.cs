//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Tables
    {
        /// <summary>
        /// Defines a <see cref='CellIndex'/> identifier
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static CellIndex cell(uint row, uint col)
            => new CellIndex(row,col);

        /// <summary>
        /// Defines a <see cref='TableRegion'/>
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        [MethodImpl(Inline), Op]
        public static TableRegion region(CellIndex min, CellIndex max)
            => new TableRegion(min,max);
   }
}