//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XVex
    {
        /// <summary>
        /// Returns the clr cell type of a vector of specified kind
        /// </summary>
        /// <param name="kind">The vector kind</param>
        [MethodImpl(Inline), Op]
        public static Type CellType(this VectorKind kind)
            => VK.celltype(kind);
    }
}