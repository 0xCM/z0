//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines a <see cref='DataWidth' subset that corresponds to x86 register widths and
    /// </summary>
    [SymbolSource]
    public enum RegWidthCode : byte
    {
        /// <summary>
        /// Indicates the width of an 8-bit register
        ///</summary>
        [Symbol("w8", "Indicates the width of an 8-bit register")]
        W8 = 0,

        /// <summary>
        /// Indicates the width of a 16-bit register
        ///</summary>
        [Symbol("w16", "Indicates the width of a 16-bit register")]
        W16 = 1,

        /// <summary>
        /// Indicates the width of a 32-bit register
        ///</summary>
        [Symbol("w32" ,"Indicates the width of a 32-bit register")]
        W32 = 2,

        /// <summary>
        /// Indicates the width of a 64-bit register
        ///</summary>
        [Symbol("w64", "Indicates the width of a 64-bit register")]
        W64 = 3,

        /// <summary>
        /// Indicates the width of a 128-bit register
        ///</summary>
        [Symbol("w128", "Indicates the width of a 128-bit register")]
        W128 = 4,

        /// <summary>
        /// Indicates the width of a 256-bit register
        ///</summary>
        [Symbol("w256", "Indicates the width of a 256-bit register")]
        W256 = 5,

        /// <summary>
        /// Indicates the width of a 512-bit register
        ///</summary>
        [Symbol("w512", "Indicates the width of a 512-bit register")]
        W512 = 6,

        /// <summary>
        /// Indicates the width of an 80-bit register
        ///</summary>
        [Symbol("w80", "Indicates the width of an 80-bit register")]
        W80 = 7,
    }
}