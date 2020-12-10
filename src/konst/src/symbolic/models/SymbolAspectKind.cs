//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x32;

    /// <summary>
    /// Defines symbol field classifiers
    /// </summary>
    [Flags]
    public enum SymbolAspectKind : uint
    {
        /// <summary>
        /// The raw/absolute symbol value
        /// </summary>
        SymbolValue = P2ᐞ00,

        /// <summary>
        /// The symbolic value's data type
        /// </summary>
        SymbolType = P2ᐞ01,

        /// <summary>
        /// The symbol value expressed in terms of a storage cell value
        /// </summary>
        CellValue = P2ᐞ02,

        /// <summary>
        /// The storage cell's data type
        /// </summary>
        CellType = P2ᐞ03,

        /// <summary>
        /// The bit-width of a symbol
        /// </summary>
        SymbolWidth = P2ᐞ04,

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        CellWidth = P2ᐞ05,

        /// <summary>
        /// The maximum number of symbols that can be packed into a single storage cell
        /// </summary>
        Capacity = P2ᐞ06,

        /// <summary>
        /// The symbol kind
        /// </summary>
        SymbolKind = P2ᐞ07,

        /// <summary>
        /// The symbol name
        /// </summary>
        SymbolName = P2ᐞ08,
    }
}