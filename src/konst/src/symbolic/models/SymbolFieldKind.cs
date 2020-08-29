//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines symbol field classifiers
    /// </summary>
    [Flags]
    public enum SymbolFieldKind : byte
    {
        /// <summary>
        /// The symbolic value
        /// </summary>
        SymbolValue = 1,

        /// <summary>
        /// The symbolic value's data type
        /// </summary>
        SymbolType = 2,

        /// <summary>
        /// The storage cell value
        /// </summary>
        CellValue = 4,

        /// <summary>
        /// The storage cell's data type
        /// </summary>
        CellType = 8,

        /// <summary>
        /// The bit-width of a symbol
        /// </summary>
        SymbolWidth = 16,

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        CellWidth = 32,

        /// <summary>
        /// The maximum number of symbols that can be packed into a single storage cell
        /// </summary>
        Capacity = 64
    }
}