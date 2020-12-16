//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Table
    {
        /// <summary>
        /// Defines a <see cref='TableCell'/> identifier
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static TableCell cell(uint row, uint col)
            => new TableCell(row,col);

        /// <summary>
        /// Defines a <see cref='TableRegion'/>
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        [MethodImpl(Inline), Op]
        public static TableRegion region(TableCell min, TableCell max)
            => new TableRegion(min,max);
   }
}