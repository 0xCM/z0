//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        /// <summary>
        /// Returns the clr cell type of a vector of specified kind
        /// </summary>
        /// <param name="kind">The vector kind</param>
        public static Type CellType(this VectorKind kind)       
            => VectorType.tcell(kind);
    }
}